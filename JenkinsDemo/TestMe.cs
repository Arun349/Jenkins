namespace JenkinsDemo
{
    public class TestMe
    {
        public string sayJenkins(int times)
        {
            string Output = "";
            for (int i = 0; i < times; i++) { 
            Output += "Jenkins";
            }
            return Output;
        }

    }
}
