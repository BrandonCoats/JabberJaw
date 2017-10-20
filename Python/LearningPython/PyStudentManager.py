# username = input("Enter user Name: ")
students = []


def get_student_titlecase():
    students_titlecase = []
    for student in students:
        students_titlecase.append(student["name"].title())
    return students_titlecase


def print_students_titlecase():
    students_titlecase = get_student_titlecase()
    for stud in students_titlecase:
        print(stud)


def add_student(name):
    students.append(name)


def add_student(name, student_id=332):
    student = {"name": name, "student_id": student_id}
    students.append(student)


def ask_to_add_student(answer):
    if answer == "yes":
        print("Please enter a name and id below: ")
        student_name2 = raw_input("Enter student name: ")
        student_id2 = raw_input("Enter student id: ")
        add_student(student_name2, student_id2)
    else:
        print_students_titlecase()

# a in the below method means to append if you use w it erases everything already in the file.


def save_file(student):
    try:
        f = open("students.txt", "a")
        f.write(student + "\n")
        f.close()
    except Exception:
        print ("Could not save file")


def read_file():
    try:
        f = open("students.txt", "r")
        for student in f.readlines():
            add_student(student)
        f.close()
    except Exception:
        print("Could not read file")


# student_list = get_student_titlecase()
read_file()
# print(students)
print_students_titlecase()

student_name = raw_input("Enter student name: ")
student_id = raw_input("Enter student id: ")

add_student(student_name, student_id)
save_file(student_name)

# add_student(student_name, student_id)
# print_students_titlecase()

# answer = raw_input("Would you like to add a student? Type yes to add one and anything else to see current students")
#  ask_to_add_student(answer)
