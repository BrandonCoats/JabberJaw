# Data types
def add_numbers(a, b):
    print(a + b)


add_numbers(7, 8)

# type hinting a: int)->int

# integers and Floats
answer = 42
pi = 3.14159
add_numbers(answer, pi)
# force type precision
print(int(pi))
print(float(answer))
# strings
'Hello World'
"Hello world"
"""All of these are valid strings"""
"hello".capitalize()  # Hello
"hello".replace("e", 'a')  # hallo
"hello".isalpha()  # true
"123".isdigit()  # true good for converting string to int
"stuff, is, whack, yo".split(',')

# string format function
element = "rain"
country = 'Spain'
place = """plain"""
# Passing in variables to a string
statement = "The {0} in {1} falls mainly on the {2}.".format(element, country, place)
# another cool way to do this
# only in 3.7 tho f"{country} is filled with {place}"
print(statement)

# boolean and none
pythonIsCool = True
pythonSuckToLearn = False

int(pythonIsCool)  # 1

aliens_found = None

# Flow Control
# if Statements
number = 5
if number == 5:
    print("Number is 5")
else:
    print("NUmber is not 5")

# any number besiides 0 has a truthy value, same with strings
# if none  always false

# not operator
if number != 5:
    print('This will not execute')

if not pythonIsCool:
    print("This willalso not execute")

# symbol for and == and, or == or
number = 3
python_course = True
if number == 3 and python_course:
    print("This will execute")

if number == 17 or python_course:
    print("This will also execute")

# ternary ifs
a = 1
b = 2
"bigger" if a > b else "smaller"

# lists kidddoooooo!
student_name = []
student_names = ['Brandon', 'John', 'Matt']

print(student_names[0])
print(student_names[1])
print(student_names[-1])  # this is matt because it grabs the first element from the right side

# add students
student_names.append("JimmyNoCaps")
# love this
if "Brandon" in student_names:
    print(student_names[0] + " is the coolest")
else:
    print("Suck it jabronie")

# find length
print(len(student_names))
# delete a person
del student_names[3]
# list slicing
print(student_names[1:])
print(student_names[1:-1])
# Loops
for name in student_names:
    print("student name is {0}".format(name))

# loops ranges
x = 0
for index in range(10):
    x += 10
    print("The value of x is {0}".format(x))

    # range(5,10,2) 5 - start 10- to 2 - increments
# breaks and continues
student_names = ['Brandon', 'John', 'Matt', 'Jordan', 'Court', 'Zach']
for name in student_names:
    if name == "Jordan":
        print("Found {0}".format(name))
        break
    print("Testing " + name)

# for name in student_names:
#   if name == "Jordan":
#        continue
#        print("Found {0}".format(name))
#    print("Testing " + name)
# while loop
y = 0
while y < 10:
    print("Count is {0}".format(y))
    y += 1


# Dictionaries
all_students = [
    {"name": "Mark", "student_id": 15163},
    {"name": "Brandon", "student_id": 15103},
    {"name": "John", "student_id": 15106}
]
student = {
    "name": "Mark",
    "student_id": 15163
}

print(all_students[0]["name"])
student.get("last_name", "Unknown")
student.keys() # gets all keys
# student_name["name"]
# student_name["name"]
del student["name"]
# Excerptions
try:
    last_name = student["last_name"]
except KeyError:
    print("error finding last_name")
except TypeError as error:
    print("Cant convert fool")
    print(error)
except Exception:
    print("Any exception")

# complex, long , bytes, bytearray, tuple , set list of unique =objects
# 



