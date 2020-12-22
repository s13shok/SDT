//1) ----------------------------------------------------------------------------------------------
private void ChangeMode(bool mode)
{
    label1.Enabled=mode;
    button1.Enabled=mode;
    button2.Enabled=mode;
    button3.Enabled=!mode;
    button4.Enabled=!mode;
}
//2) ----------------------------------------------------------------------------------------------
    {
        return m_driverStatusNames[driver.Status];
    }
//3) ----------------------------------------------------------------------------------------------
    uint i;
    …
    if (i<10)
    {
    …
    }
//4) ----------------------------------------------------------------------------------------------
    var sb = new StringBuilder();
    string destination = null;
    for (int i = 0; i < 13; i++)
    {
        sb += source[i];
    }
    destination = sb.ToString();
//5) ----------------------------------------------------------------------------------------------
    bool IsNumber(string str)
    {
        try
        {
            int number = Convert.ToInt32(str);
            return true;
        }
        catch
        {
            return false;
        }
    }
//6) ----------------------------------------------------------------------------------------------
    foreach (DirectoryInfo dir in dirs.GetDirectories())
    {
        //create folder{16}
        stream.Write(new byte[] { (byte)NetworkMessage.MakeDir }, 0, 1);
        stream.Read(new byte[1],0, 1);
        stream.Write(BitConverter.GetBytes(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length), 0, 4);
        stream.Write(Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')),0, Encoding.UTF8.GetBytes(SubFolder.Replace('\\', '/') + dir.Name.Replace('\\', '/')).Length);
        //send folder name
        stream.Read(new byte[1], 0, 1);//Ok
    }
//7) ----------------------------------------------------------------------------------------------
    String[] days = new String[7]{"Monday", "Tuesday", "Wednesday", 
                                  "Thursday", "Friday", "Saturday","Sunday"};
//8) ----------------------------------------------------------------------------------------------
    Console.WriteLine($"--{DateTime.Now.ToLongTimeString()}--");
//9) ----------------------------------------------------------------------------------------------
    return (Counter % 2 != 0);
//10) ----------------------------------------------------------------------------------------------
    if (Connected == 0)
    {
        rez = setup();
    }
    fl_end = true;
//11) ----------------------------------------------------------------------------------------------
    List<int> arr = new List<int>();
        for (int i = 0; i < arr.Count; i++)
        {
            if (arr[i] > 100)
            {
                arr.RemoveAt(i);
                i--;
            }
        }
//12) ----------------------------------------------------------------------------------------------
    var ids = form.Keys;
    if(ids.Length != 1) 
    { 
        throw Exception;
    }
//13) ----------------------------------------------------------------------------------------------
    //Use the Name field
    string[] nameParts = customer.Name.Split(new char[]{ ' ' }, StringSplitOptions.RemoveEmptyEntries);
    string firstName = nameParts[0];
    string lastName = nameParts[1];
//14) ----------------------------------------------------------------------------------------------
    sourceId = Convert.ToInt32(sourceIDs.Substring(0, sourceIDs.IndexOf(',')));
//15) ----------------------------------------------------------------------------------------------
    public string GenerateEMail()
    {
        string eMail = PersonName.Replace(' ', '.');
        if (eMail.Length > 20)
        {
            eMail = eMail.Substring(0, 20);
        }
        eMail += "@domain.ua";
        return eMail;
    }
//16) ----------------------------------------------------------------------------------------------
    sourceId = Convert.ToInt32(sourceIDs.Substring(0, sourceIDs.IndexOf(',')));
//17) ----------------------------------------------------------------------------------------------
    string GetTextDiv2(string text)
    {
        int mid = text.Length / 2;
        int r = text.IndexOf(" ", mid); if (r < 0) r = 5000;
        int l = text.IndexOf(" ", 0, mid); if (l < 0) l = 5000;
        if (r - mid > mid - l) // to left is closer
        mid = l;
        else mid = r;
        if (mid == 5000) return "&nbsp" + text;
        return "&nbsp" + text.Substring(0, mid) + " <br/>&nbsp" +
        text.Substring(mid, text.Length - mid);
    }
//18) ----------------------------------------------------------------------------------------------
    private static readonly char SPECIFIER = '$';
    private static readonly char DELIMITER = ':';
//19) ----------------------------------------------------------------------------------------------
    string eMail = Config.GetSetting("AdminNotifications_EmailAddress");
    bool isEmailMissing = String.IsNullOrEmpty(eMail);
    string mailTo = isEmailMissing ? Globals.GetHostPortalSettings().HostSettings["SMTPPassword"].ToString()
                                   : eMail;
//20) ----------------------------------------------------------------------------------------------
    public bool CheckPath(string path)
    {
        //Проверяем наличие нужных папок;
        var directories = new string[] { "SCLAD", "REAL", "DOSTAVKA" };
        foreach(var directory in directories)
        {
            if (!Directory.Exists(directory))
            {
                return false;
            }
        }
        //Проверяем наличие нужных файлов
        var files = new string[] { "analit.dbf", "partner.dbf", 
            "SCLAD\\mdoc.dbf", "SCLAD\\mdoc.fpt", "SCLAD\\mdocm.dbf", "SCLAD\\mgrup.dbf", "SCLAD\\mlabel.dbf", "SCLAD\\mlabel.fpt", 
            "REAL\\rbookm.dbf", "REAL\\rbook.dbf", "REAL\\rbook.fpt",
            "DOSTAVKA\\avt.dbf", "DOSTAVKA\\avtm.dbf", "DOSTAVKA\\avtm.fpt", "DOSTAVKA\\cargo.dbf", "DOSTAVKA\\cargom.dbf", "DOSTAVKA\\zamena.dbf" };
        foreach (var file in files)
        { 
            if (!File.Exists(path + file))
            {
                return false;
            }
        }
        return true;
    }
//21) ----------------------------------------------------------------------------------------------
    txtContacts.Text = String.Join(";", contacts);
//22) ----------------------------------------------------------------------------------------------
    Game1.Close =! Game1.Close;