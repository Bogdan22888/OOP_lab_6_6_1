namespace OOP_lab_6_6_1
{
	interface IStudent
	{
		string GetLastName();
		int GetGradebookId();
		int GetRating();
		void SetLastName(string surname);
		void SetGradebookId(int id);
		void SetRating(int r);
		void Sort(Student[] students);
		double GetAverageRating(Student[] students);
		int GetUnderAverageAmount(Student[] students);
		void Output(Student[] students);
	}
}
