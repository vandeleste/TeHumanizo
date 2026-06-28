class Program{
    static void Main(string[]dirTemp){
        //data_Utau[]
    }
    static void Log(string text){
        string path_log=AppContext.BaseDirectory+"log_plugin.txt";
        File.AppendAllText(path_log,text+"\n");
    }
}

