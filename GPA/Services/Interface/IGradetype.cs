namespace GPA
{
    public interface IGradetype
    {
        char Grade(int courseScore);
        byte GradeUnit(char grade);
    }
}