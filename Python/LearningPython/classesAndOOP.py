students = []


class Student:
    def __init__(self, name, student_id=332):
        self.name = name
        self.student_id = student_id
        students.append(self)

    def __str__(self):
        return "Student " + self.name

    def get_name_capitalize(self):
        return self.name.capitalize()


# brandon = Student("Brandon")


# print(brandon)

# class attributes example.

class Student:
    school_name = "springfield Elementary"

    def __init__(self, name, student_id=332):
        self.name = name
        self.student_id = student_id
        students.append(self)

    def __str__(self):
        return "Student " + self.name

    def get_name_capitalize(self):
        return self.name.capitalize()

    def get_school_name(self):
        return self.school_name


# print(Student.school_name)

# inheritence and polymorphisum
# above class is parent this is the child


class HighSchoolStudent(Student):
    school_name = "SpringField HighSchool"
    # overides

    def get_school_name(self):
        return "This is a High School Student"

# This method adds behavoir without having to change it
# doesnt work in python 2
#    def get_name_capitalize(self):
#        original_value = super().get_name_capitalize()
#        return original_value + "-HS"


# james = HighSchoolStudent("James")
# print(james.get_name_capitalize())

# no interfaces in python
