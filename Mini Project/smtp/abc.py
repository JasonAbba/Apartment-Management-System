#I/O operations 
file = open("Input.txt")
f = file.readlines()

L1 = []

for w in f:
    L1.append(w)

text = []
text = [str(i) for i in L1] 
inp = text[0]
print(inp)
#End of I/O
