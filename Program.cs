class Program{
    static void main(string[]dirTemp){
        //data_Utau[]
    }
    static void Log(string text){
        path_log=AppContext.BaseDirectory+"log_plugin.txt";;
        File.AppendAllText(path_log,text+"\n");
    }
}

