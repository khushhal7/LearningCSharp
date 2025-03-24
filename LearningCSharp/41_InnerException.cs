public class _41_InnerException{
    public static void Main(){
        try{
            try{
                Console.WriteLine("Enter Divident : ");
                int fN = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Divisor : ");
                int sN = Convert.ToInt32(Console.ReadLine());
                int result = fN/sN;
            }
            catch(Exception ex){
                string filePath = @"C:\Users\khush\source\repos\LearningCSharp\LearningCSharp\Log1.txt";
                if(File.Exists(filePath)){
                    StreamWriter sw = new(filePath);
                    sw.Write(ex.GetType().Name);
                    sw.WriteLine();
                    sw.WriteLine(ex.Message);
                    sw.Close();
                }
                else{
                    throw new FileNotFoundException(filePath + "is not Present", ex);
                }
            }
        }
        catch(Exception exception){
            Console.WriteLine("Current Exception : {0}", exception.GetType().Name);
            if(exception.InnerException != null){
                Console.WriteLine("Inner Exception : {0}", exception.InnerException.GetType().Name);
            }
        }
        
    }
}