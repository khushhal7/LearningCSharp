
public class _40_Exception_Handling
{
    public static void Main()
    {
        StreamReader streamReader = null;
        try{
            streamReader = new (@"C:\Users\khush\source\repos\LearningCSharp\LearningCSharp\File1.txt");
            Console.WriteLine(streamReader.ReadToEnd());
        }
        catch(FileNotFoundException ex){
            //specific exception will execute when the try block throw FileNotFoundException.
            //it inherits the properties from general exception.
            Console.WriteLine("please check this file in directory {0}", ex.FileName);

        }
        catch(Exception ex){
            //general exception
            Console.WriteLine(ex.Message);
            Console.WriteLine(ex.StackTrace);
        }
        finally{
            //close the resource
            //if there is no file or directory the streamReader will be null, so at first we will check
            //that streamReader is null or not, if null then we don't need to close it.
            if(streamReader != null){
                streamReader.Close();
            }
        }
    }
}
