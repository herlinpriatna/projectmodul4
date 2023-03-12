internal class Data {
    public Data()
    {
    }
    
    public enum Kelurahan { Batununggal, Kujangsari, Mengger, Wates, Cijaura, Jatisari, Margasari, Sekejati, Kebonwaru, Maleer, Samoja };

    public static int GetKodePos(Kelurahan kelurahan)
    {
        int[] kodepos = { 40266, 40287, 40267, 40256, 40287, 40286, 40286, 40286, 40272, 40274, 40273 };
        return kodepos[(int)kelurahan];
    }

}

class main
{
    
    static void Main(string[] args)
    {
        Data data = new Data();

        Data.Kelurahan kelurahan = Data.Kelurahan.Batununggal;
        Console.WriteLine(Data.GetKodePos(kelurahan));


        DoorMachine door = new DoorMachine();
        DoorMachine.State.TERKUNCI;
    }



  
}



class DoorMachine
{
    State state;

    public DoorMachine()
    {
    }
    public enum State
    {
        TERKUNCI,
        TERBUKA
    }
    public void SetState(State state)
    {
        if (state == State.TERBUKA)
        {
            
            Console.WriteLine("Pintu tidak terkunci");
            }
            else if (state == State.TERKUNCI)
            {
                Console.WriteLine("Pintu terkunci");
            }
        }
    }

   
