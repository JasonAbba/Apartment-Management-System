from datetime import datetime
from datetime import date
Name=input("Name of Visitor :")
numb=input("Phone Number of Visitor :")
noofv=input("Number of Visitors :")
print("\nVisitor(s) for:")
List=("1.Ram Murthy","2.Deepak Haridas","3.Jason Abba","4.Keerthan","5.Danish")
noList=("Ram Murthy","Deepak Haridas","Jason Abba","Keerthan","Danish")
add=("101","102","201","202","Pent House")
vpark=("1P","2P","3P","4P","5P")
for tenant in List:
    print(tenant)
number=int(input("\nTenant No.:"))
que=int(input("Visitor availed parking?(1-yes|0-no):"))
if(que==1):
    vehicle=int(input("Two Wheeler or Four Wheeler(1-yes|0-no):"))
    plate=input("License Plate No. :")
print("\n\n\nName of Visitor         :",Name)
print("Phone Number of Visitor :",numb)
print("Number of Visitors      :",noofv)
print("Visitor(s) for          :",noList[number-1])
print("Flat                    :",add[number-1])
if(que==1):
    print("Visitor availed parking : Yes")
    if(vehicle==1):
        print("Vehicle                 : Two Wheeler")
    else:
        print("Vehicle                 : Four Wheeler")
    print("Vehicle Licence Plate   :",plate)
    print("Parking space alloted   :",vpark[number-1])
    now=datetime.now()
    current_time=now.strftime("%H:%M:%S")
    print("Time alloted            :",current_time)
    print("                         ",date.today())
    
else:
    print("Visitor availed parking : No")
