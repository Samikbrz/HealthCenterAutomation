using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace SaglıkOcagıOtomasyonu
{
    public class DatabaseTransactions
    {

        public List<Users> _UserInputControler = new List<Users>();
        public List<Poliklinik> _polikliniks = new List<Poliklinik>();
        public List<Sevk> _sevks = new List<Sevk>();
        public List<Users> _users = new List<Users>();
        public List<Patient> _patients = new List<Patient>();
        public List<Operation> _operations = new List<Operation>();
        public List<Sevk> FilesNumber = new List<Sevk>();
        public List<Exit> _exits = new List<Exit>();
        public Boolean Kontrol { get; set; }
        SqlConnection _connection = new SqlConnection(@"Data Source=DESKTOP-J2CDTPM\SQLEXPRESS;Initial Catalog=HastaTakipOtomasyonu;Integrated Security=True");

        public DatabaseTransactions()
        {

        }

        public void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }

        public List<Users> UserInputControler()
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Select UserName,Sifre,Yetki From Kullanici", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users usersTwo = new Users
                    {
                        KullaniciAdi = reader["UserName"].ToString(),
                        Sifre = reader["Sifre"].ToString(),
                        Yetki = reader["Yetki"].ToString()
                    };
                    _UserInputControler.Add(usersTwo);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataUserInputControl=" + e);
            }
            finally
            {
                _connection.Close();
            }
            return _UserInputControler;
        }

        public List<Operation> GetAllOperationAndPrice()
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Select * From Islem", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Operation operation = new Operation
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        IslemAdi = reader["IslemAdi"].ToString(),
                        BirimFiyat = Convert.ToInt32(reader["BirimFiyat"]),
                    };
                    _operations.Add(operation);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataGetAllOperationAndPrice=" + e);
            }
            finally
            {
                _connection.Close();
            }
            return _operations;
        }

        public List<Sevk> GetAllSevk()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Sevk", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Sevk sevk = new Sevk
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    TCKimlikNo = reader["TCKimlikNo"].ToString(),
                    DosyaNo = reader["DosyaNo"].ToString(),
                    Poliklinik = reader["Poliklinik"].ToString(),
                    Sira = Convert.ToInt32(reader["Sira"]),
                    YapılanIslem = reader["YapılanIslem"].ToString(),
                    DrKodu = reader["Drkod"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    BirimFiyat = Convert.ToInt32(reader["BirimFiyat"]),
                    SevkTarihi = Convert.ToDateTime(reader["SevkTarihi"]),
                    Saat = Convert.ToDateTime(reader["Saat"]),
                    taburcu = reader["Taburcu"].ToString()
                };
                _sevks.Add(sevk);
            }
            reader.Close();
            _connection.Close();
            return _sevks;
        }

        public List<Sevk> GetAllSevkSearch()
        {
            List<Sevk> result = new List<Sevk>();
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Sevk", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Sevk sevk = new Sevk
                {
                    ID = Convert.ToInt32(reader["ID"]),
                    TCKimlikNo = reader["TCKimlikNo"].ToString(),
                    DosyaNo = reader["DosyaNo"].ToString(),
                    Poliklinik = reader["Poliklinik"].ToString(),
                    Sira = Convert.ToInt32(reader["Sira"]),
                    YapılanIslem = reader["YapılanIslem"].ToString(),
                    DrKodu = reader["Drkod"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    BirimFiyat = Convert.ToInt32(reader["BirimFiyat"]),
                    SevkTarihi = Convert.ToDateTime(reader["SevkTarihi"]),
                    Saat = Convert.ToDateTime(reader["Saat"]),
                    taburcu = reader["Taburcu"].ToString()
                };
                result.Add(sevk);
            }
            reader.Close();
            _connection.Close();
            return result;
        }

        public void AddSevk(Sevk sevk)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "Insert into Sevk(DosyaNo,SevkTarihi,ToplamTutar,TCKimlikNo,Saat,Poliklinik, Sira, YapılanIslem, Drkod, BirimFiyat,Miktar) values(@DosyaNo,@SevkTarihi,@ToplamTutar,@TCKimlikNo,@Saat,@Poliklinik,@Sira,@YapılanIslem,@Drkod,@BirimFiyat,@Miktar)", _connection);
            command.Parameters.AddWithValue("@SevkTarihi", sevk.SevkTarihi);
            command.Parameters.AddWithValue("@ToplamTutar", sevk.ToplamTutar);
            command.Parameters.AddWithValue("@TCKimlikNo", sevk.TCKimlikNo);
            command.Parameters.AddWithValue("@Saat", sevk.Saat);
            command.Parameters.AddWithValue("@Poliklinik", sevk.Poliklinik);
            command.Parameters.AddWithValue("@Sira", sevk.Sira);
            command.Parameters.AddWithValue("@YapılanIslem", sevk.YapılanIslem);
            command.Parameters.AddWithValue("@Drkod", sevk.DrKodu);
            command.Parameters.AddWithValue("@BirimFiyat", sevk.BirimFiyat);
            command.Parameters.AddWithValue("@Miktar", sevk.Miktar);
            command.Parameters.AddWithValue("@DosyaNo", sevk.DosyaNo);
            command.ExecuteNonQuery();
            _connection.Close();
        }

        public void DeleteSevk(int Id)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand(
                    "Delete from Sevk where Id=@ID", _connection);
                command.Parameters.AddWithValue("@ID", Id);
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataDeleteSevk=" + e);
            }
            finally
            {
                MessageBox.Show("Sevk Silinid");
                _connection.Close();
            }
        }

        public void DeletePoliklinik(int Id)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand(
                    "Delete from Poliklinik where Id=@ID", _connection);
                command.Parameters.AddWithValue("@ID", Id);
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataDeletePoliklinik=" + e);
            }
            finally
            {
                MessageBox.Show("Poliklinik Silindi");
                _connection.Close();
            }
        }

        public void DeleteUser(int Id)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand(
                    "Delete from Kullanici where Id=@ID", _connection);
                command.Parameters.AddWithValue("@ID", Id);
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataDeleteUser=" + e);
            }
            finally
            {
                MessageBox.Show("Kullanici Silindi");
                _connection.Close();
            }
        }

        public void UpdatePolikliniks(Poliklinik poliklinik)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Update Poliklinik set PoliklinikAdi=@PoliklinikAdi,Acıklama=@Acıklama where ID=@ID", _connection);
                command.Parameters.AddWithValue("@PoliklinikAdi", poliklinik.PoliklinikAdi);
                command.Parameters.AddWithValue("@Durum", poliklinik.Durum);
                command.Parameters.AddWithValue("@Acıklama", poliklinik.Acıklama);
                command.Parameters.AddWithValue("@ID", poliklinik.ID);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataUpdatePolikliniks=" + e);
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }


        public void AddPoliklinik(Poliklinik poliklinik)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand(
                    "Insert into Poliklinik(Poliklinik, Durum, Acıklama) values(@PoliklinikAdi,@Durum,@Acıklama)", _connection);
                command.Parameters.AddWithValue("@Poliklinik", poliklinik.PoliklinikAdi);
                command.Parameters.AddWithValue("@Durum", poliklinik.Durum);
                command.Parameters.AddWithValue("@Acıklama", poliklinik.Acıklama);
                command.ExecuteNonQuery();
                _connection.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataAddPoliklinik=" + e);
            }
            finally
            {
                _connection.Close();
            }

        }

        public List<Poliklinik> GetAllPoliklinikInformation()
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Select * From Poliklinik", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Poliklinik poliklinik = new Poliklinik
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        PoliklinikAdi = reader["PoliklinikAdi"].ToString(),
                        Durum = reader["Durum"].ToString(),
                        Acıklama = reader["Acıklama"].ToString()
                    };
                    _polikliniks.Add(poliklinik);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataGetAllPoliklinikInformation=" + e);
            }
            finally
            {
                _connection.Close();
            }
            return _polikliniks;
        }

        public List<Users> GetAllUsers()
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Select * From Kullanici", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Users user = new Users
                    {
                        ID = Convert.ToInt32(reader["ID"]),
                        KullaniciKodu = Convert.ToInt32(reader["KullaniciKodu"]),
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        Sifre = reader["Sifre"].ToString(),
                        Yetki = reader["Yetki"].ToString(),
                        EvTel = Convert.ToDecimal(reader["EvTel"]),
                        CepTel = Convert.ToDecimal(reader["CepTel"]),
                        Adres = reader["Adres"].ToString(),
                        Unvan = reader["Unvan"].ToString(),
                        IseBaslama = Convert.ToDateTime(reader["IseBaslama"]),
                        Maas = Convert.ToDecimal(reader["Maas"]),
                        DogumYeri = reader["DogumYeri"].ToString(),
                        AnneAdi = reader["AnneAdi"].ToString(),
                        BabaAdi = reader["BabaAdi"].ToString(),
                        DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                        TC = reader["TcKimlikNo"].ToString(),
                        KullaniciAdi = reader["UserName"].ToString(),
                        Cinsiyet = reader["Cinsiyet"].ToString(),
                        MedeniHali = reader["MedeniHali"].ToString(),
                        KanGrubu = reader["KanGrubu"].ToString()
                    };
                    _users.Add(user);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataGetAllUsers=" + e);
            }
            finally
            {
                _connection.Close();
            }
            return _users;
        }

        public void UpdateKullanıcıTanıtma(Users users)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Update Kullanici set Ad=@Ad, Soyad=@Soyad,Sifre=@Sifre,EvTel=@EvTel,CepTel=@GSM,Adres=@Adres," +
                    "Unvan=@Unvan,IseBaslama=@IseBaslama,Maas=@Maas,DogumYeri=@DogumYeri,AnneAdi=@AnneAdi,BabaAdi=@BabaAdi,Cinsiyet=@Cinsiyet,KanGrubu=@KanGrubu,MedeniHali=@MedeniHali," +
                    "DogumTarihi=@DogumTarihi,TcKimlikNo=@TC,UserName=@KullaniciAdi, Yetki=@Yetki where ID=@ID", _connection);
                command.Parameters.AddWithValue("@Ad", users.Ad);
                command.Parameters.AddWithValue("@Soyad", users.Soyad);
                command.Parameters.AddWithValue("@Sifre", users.Sifre);
                command.Parameters.AddWithValue("@EvTel", users.EvTel);
                command.Parameters.AddWithValue("@GSM", users.CepTel);
                command.Parameters.AddWithValue("@Adres", users.Adres);
                command.Parameters.AddWithValue("@Unvan", users.Unvan);
                command.Parameters.AddWithValue("@IseBaslama", users.IseBaslama);
                command.Parameters.AddWithValue("@Maas", users.Maas);
                command.Parameters.AddWithValue("@DogumYeri", users.DogumYeri);
                command.Parameters.AddWithValue("@AnneAdi", users.AnneAdi);
                command.Parameters.AddWithValue("@BabaAdi", users.BabaAdi);
                command.Parameters.AddWithValue("@Cinsiyet", users.Cinsiyet);
                command.Parameters.AddWithValue("@KanGrubu", users.KanGrubu);
                command.Parameters.AddWithValue("@MedeniHali", users.MedeniHali);
                command.Parameters.AddWithValue("@DogumTarihi", users.DogumTarihi);
                command.Parameters.AddWithValue("@TC", users.TC);
                command.Parameters.AddWithValue("@KullaniciAdi", users.KullaniciAdi);
                command.Parameters.AddWithValue("@Yetki", users.Yetki);
                command.Parameters.AddWithValue("@ID", users.ID);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataUpdateKullanıcıTanıtma=" + e);
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        public void AddNewUsers(Users users)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Insert into Kullanici(TcKimlikNo,Unvan, Ad,Soyad,DogumYeri,BabaAdi,AnneAdi,Cinsiyet,KanGrubu,MedeniHali,Maas,EvTel,CepTel,Yetki,IseBaslama,DogumTarihi,Adres,UserName,Sifre,KullaniciKodu) " +
                    "values(@TC,@Unvan, @Ad, @Soyad,@DogumYeri,@BabaAdi,@AnneAdi,@Cinsiyet,@KanGrubu,@MedeniHali,@Maas,@EvTel,@CepTel,@Yetki,@IseBaslama,@DogumTarihi,@Adres,@KullaniciAdi,@Sifre,@KullaniciKodu)", _connection);
                command.Parameters.AddWithValue("@TC", users.TC);
                command.Parameters.AddWithValue("@Unvan", users.Unvan);
                command.Parameters.AddWithValue("@Ad", users.Ad);
                command.Parameters.AddWithValue("@Soyad", users.Soyad);
                command.Parameters.AddWithValue("@DogumYeri", users.DogumYeri);
                command.Parameters.AddWithValue("@BabaAdi", users.BabaAdi);
                command.Parameters.AddWithValue("@AnneAdi", users.AnneAdi);
                command.Parameters.AddWithValue("@Cinsiyet", users.Cinsiyet);
                command.Parameters.AddWithValue("@KanGrubu", users.KanGrubu);
                command.Parameters.AddWithValue("@MedeniHali", users.MedeniHali);
                command.Parameters.AddWithValue("@Maas", users.Maas);
                command.Parameters.AddWithValue("@EvTel", users.EvTel);
                command.Parameters.AddWithValue("@CepTel", users.CepTel);
                command.Parameters.AddWithValue("@Yetki", users.Yetki);
                command.Parameters.AddWithValue("@IseBaslama", users.IseBaslama);
                command.Parameters.AddWithValue("@DogumTarihi", users.DogumTarihi);
                command.Parameters.AddWithValue("@Adres", users.Adres);
                command.Parameters.AddWithValue("@KullaniciAdi", users.KullaniciAdi);
                command.Parameters.AddWithValue("@Sifre", users.Sifre);
                command.Parameters.AddWithValue("@KullaniciKodu", users.KullaniciKodu);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataAddNewUsers=" + e);
            }
            finally
            {
                MessageBox.Show("Kişi Eklendi");
                _connection.Close();
            }
        }


        public void AddNewPolylinic(Poliklinik poliklinik)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Insert into Poliklinik(PoliklinikAdi,Durum,Acıklama) values(@PoliklinikAdi,@Durum,@Acıklama)", _connection);
                command.Parameters.AddWithValue("@PoliklinikAdi", poliklinik.PoliklinikAdi);
                command.Parameters.AddWithValue("@Durum", poliklinik.Durum);
                command.Parameters.AddWithValue("@Acıklama", poliklinik.Acıklama);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataAddNewPolylinic=" + e);
            }
            finally
            {
                MessageBox.Show("Poliklinik Eklendi");
                _connection.Close();
            }
        }


        public List<Patient> GetALLPatient()
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Select * From Hasta", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Patient patient = new Patient
                    {
                        TC = reader["TCKimlikNo"].ToString(),
                        DosyaNo = reader["DosyaNo"].ToString(),
                        Ad = reader["Ad"].ToString(),
                        Soyad = reader["Soyad"].ToString(),
                        DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                        DogumYeri = reader["DogumYeri"].ToString(),
                        BabaAdi = reader["BabaAdi"].ToString(),
                        AnneAdi = reader["AnneAdi"].ToString(),
                        Adres = reader["Adres"].ToString(),
                        CepTel = Convert.ToDecimal(reader["CepTel"]),
                        KurumSicilNo = Convert.ToInt32(reader["KurumSicilNo"]),
                        KurumAdi = reader["KurumAdi"].ToString(),
                        YakınTel = Convert.ToDecimal(reader["YakinTel"]),
                        YakınKurumSicilNo = Convert.ToInt32(reader["YakinKurumSicilNo"]),
                        YakınKurumAdi = reader["YakinKurumAdi"].ToString(),
                        Cinsiyet = reader["Cinsiyet"].ToString(),
                        KanGrubu = reader["KanGrubu"].ToString(),
                        MedeniHali = reader["MedeniHali"].ToString(),
                    };
                    _patients.Add(patient);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataGetPatient=" + e);
                throw;
            }
            return _patients;
        }


        public List<Patient> GetALLPatientSearch()
        {
            List<Patient> patients = new List<Patient>();
            ConnectionControl();
            SqlCommand command = new SqlCommand("Select * From Hasta", _connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Patient patient = new Patient
                {
                    TC = reader["TCKimlikNo"].ToString(),
                    DosyaNo = reader["DosyaNo"].ToString(),
                    Ad = reader["Ad"].ToString(),
                    Soyad = reader["Soyad"].ToString(),
                    DogumTarihi = Convert.ToDateTime(reader["DogumTarihi"]),
                    DogumYeri = reader["DogumYeri"].ToString(),
                    BabaAdi = reader["BabaAdi"].ToString(),
                    AnneAdi = reader["AnneAdi"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    CepTel = Convert.ToDecimal(reader["CepTel"]),
                    KurumSicilNo = Convert.ToInt32(reader["KurumSicilNo"]),
                    KurumAdi = reader["KurumAdi"].ToString(),
                    YakınTel = Convert.ToDecimal(reader["YakinTel"]),
                    YakınKurumSicilNo = Convert.ToInt32(reader["YakinKurumSicilNo"]),
                    YakınKurumAdi = reader["YakinKurumAdi"].ToString(),
                    Cinsiyet = reader["Cinsiyet"].ToString(),
                    KanGrubu = reader["KanGrubu"].ToString(),
                    MedeniHali = reader["MedeniHali"].ToString(),
                };
                patients.Add(patient);
            }
            reader.Close();
            return patients;
        }


        public void SavePatient(Patient patient)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Update Hasta set TCKimlikNo=@TC, Ad=@Ad, Soyad=@Soyad, DogumTarihi=@DogumTarihi,DogumYeri=@DogumYeri,BabaAdi=@BabaAdi,AnneAdi=@AnneAdi," +
                    "Adres=@Adres,CepTel=@CepTel,KurumSicilNo=@KurumSicilNo,KurumAdi=@KurumAdi,YakinTel=@YakinTel,YakinKurumSicilNo=@YakınKurumSicilNo,Cinsiyet=@Cinsiyet," +
                    "KanGrubu=@KanGrubu,MedeniHali=@MedeniHali,YakinKurumAdi=@YakinKurumAdi where TCKimlikNo=@TC", _connection);
                command.Parameters.AddWithValue("@TC", patient.TC);
                command.Parameters.AddWithValue("@Ad", patient.Ad);
                command.Parameters.AddWithValue("@Soyad", patient.Soyad);
                command.Parameters.AddWithValue("@DogumTarihi", patient.DogumTarihi);
                command.Parameters.AddWithValue("@DogumYeri", patient.DogumYeri);
                command.Parameters.AddWithValue("@BabaAdi", patient.BabaAdi);
                command.Parameters.AddWithValue("@AnneAdi", patient.AnneAdi);
                command.Parameters.AddWithValue("@YakınKurumSicilNo", patient.YakınKurumSicilNo);
                command.Parameters.AddWithValue("@Cinsiyet", patient.Cinsiyet);
                command.Parameters.AddWithValue("@KanGrubu", patient.KanGrubu);
                command.Parameters.AddWithValue("@MedeniHali", patient.MedeniHali);
                command.Parameters.AddWithValue("@Adres", patient.Adres);
                command.Parameters.AddWithValue("@CepTel", patient.CepTel);
                command.Parameters.AddWithValue("@KurumSicilNo", patient.KurumSicilNo);
                command.Parameters.AddWithValue("@KurumAdi", patient.KurumAdi);
                command.Parameters.AddWithValue("@YakinTel", patient.YakınTel);
                command.Parameters.AddWithValue("@YakinKurumAdi", patient.YakınKurumAdi);
                command.Parameters.AddWithValue("@DosyaNo", patient.DosyaNo);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataSavePatient=" + e);
                throw;
            }
            finally
            {
                _connection.Close();
            }
        }

        public void SearchWithTC(string TCKimlikNo)
        {
            

            ConnectionControl();
            SqlCommand command = new SqlCommand("SELECT TCKimlikNo FROM Sevk WHERE DosyaNo LIKE @TCKimlikNo", _connection);
            var TCNo = "%" + TCKimlikNo.Trim() + "%";
            command.Parameters.AddWithValue("@TCKimlikNo", TCNo);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                Sevk sevkTwo = new Sevk
                {
                    DosyaNo = reader["TCKimlikNo"].ToString()
                };
                FilesNumber.Add(sevkTwo);
            }
            reader.Close();
            _connection.Close();
        }

        public void NewPatientInformationSave(Patient patient)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Insert into Hasta(TCKimlikNo, Ad,Soyad,DogumTarihi,DogumYeri,BabaAdi,AnneAdi,Cinsiyet,KanGrubu,MedeniHali,Adres,CepTel,KurumSicilNo,KurumAdi,YakinTel,YakinKurumSicilNo,YakinKurumAdi) " +
                    "values(@TC, @Ad, @Soyad,@DogumTarihi,@DogumYeri,@BabaAdi,@AnneAdi,@Cinsiyet,@KanGrubu,@MedeniHali,@Adres,@CepTel,@KurumSicilNo,@KurumAdi,@YakinTel,@YakınKurumSicilNo,@YakınKurumAdi)", _connection);
                command.Parameters.AddWithValue("@TC", patient.TC);
                command.Parameters.AddWithValue("@Ad", patient.Ad);
                command.Parameters.AddWithValue("@Soyad", patient.Soyad);
                command.Parameters.AddWithValue("@DogumTarihi", patient.DogumTarihi);
                command.Parameters.AddWithValue("@DogumYeri", patient.DogumYeri);
                command.Parameters.AddWithValue("@BabaAdi", patient.BabaAdi);
                command.Parameters.AddWithValue("@AnneAdi", patient.AnneAdi);
                command.Parameters.AddWithValue("@Cinsiyet", patient.Cinsiyet);
                command.Parameters.AddWithValue("@KanGrubu", patient.KanGrubu);
                command.Parameters.AddWithValue("@MedeniHali", patient.MedeniHali);
                command.Parameters.AddWithValue("@Adres", patient.Adres);
                command.Parameters.AddWithValue("@CepTel", patient.CepTel);
                command.Parameters.AddWithValue("@KurumSicilNo", patient.KurumSicilNo);
                command.Parameters.AddWithValue("@KurumAdi", patient.KurumAdi);
                command.Parameters.AddWithValue("@YakinTel", patient.YakınTel);
                command.Parameters.AddWithValue("@YakınKurumSicilNo", patient.YakınKurumSicilNo);
                command.Parameters.AddWithValue("@YakınKurumAdi", patient.YakınKurumAdi);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataNewPatientInformationSave=" + e);
            }
            finally
            {
                _connection.Close();
            }
        }


        public void ExitSave(Exit exit)
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Insert into Cikis(TCKimlikNo, SevkTarihi,CıkısTarihi,Odeme,ToplamTutar) values(@TC, @SevkTarihi, @CıkısSaati,@Odeme,@ToplamTutar)", _connection);
                command.Parameters.AddWithValue("@TC", exit.TC);
                command.Parameters.AddWithValue("@SevkTarihi", exit.SevkTarihi);
                command.Parameters.AddWithValue("@CıkısSaati", exit.CıkısTarihi);
                command.Parameters.AddWithValue("@Odeme", exit.Odeme);
                command.Parameters.AddWithValue("@ToplamTutar", exit.ToplamTutar);
                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataExit=" + e);
            }
            finally
            {
                MessageBox.Show("Ödeme Tamamlandı");
                _connection.Close();
            }
        }

        public List<Exit> GetAllExit()
        {
            try
            {
                ConnectionControl();
                SqlCommand command = new SqlCommand("Select * From Cikis", _connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Exit exit = new Exit
                    {
                        TC = reader["TCKimlikNo"].ToString(),
                    };
                    _exits.Add(exit);
                }
                reader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("HataGetAllExit=" + e);
                throw;
            }
            return _exits;
        }
    }
}
