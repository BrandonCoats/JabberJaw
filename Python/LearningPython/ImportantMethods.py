students = []


def get_student_titlecase():
    students_titlecase = []
    for student in students:
        students_titlecase = student.title()
    return students_titlecase


def print_students_titlecase():
    students_titlecase = get_student_titlecase()
    print(students_titlecase)


def add_student(name):
    students.append(name)


def add_student(name, student_id=332):
    student = {"name": name, "student_id": student_id}
    students.append(student)


student_list = get_student_titlecase()


def var_args(name, *args):
    print(name)
    print(args)


def var_argskw(name, **kwargs):
    print(name)
    print(kwargs["description"], kwargs["feedback"])


student_list = get_student_titlecase()


add_student("Mark")

add_student("Matty", 76)

add_student(name="Matty", student_id=76)

print("Hello", "World", 3, None, "Something")

var_args("Mark", "lemon", None, "Hello", True)

var_argskw("Mark", description="loves python", feedback=None, pluralsight_sucscriber=True)
# functions can be nested inside of functions
