import smtplib, ssl


#I/O operations for Input
file = open("Input.txt")
f = file.readlines()

L1 = []

for w in f:
    L1.append(w)

text = []
text = [str(i) for i in L1] 
name = text[0]
#End of I/O

#I/O operations for email
file = open("em.txt")
f = file.readlines()

L1 = []

for w in f:
    L1.append(w)

text = []
text = [str(i) for i in L1] 
em = text[0]
#End of I/O


inp = "You have a visitor: " + name


smtp_server = "smtp.gmail.com"
port = 587  # For starttls
sender_email = "officialpython20@gmail.com"
password = "pteokiibauxvqydc"

# Create a secure SSL context
context = ssl.create_default_context()


# Try to log in to server and send email
try:
    server = smtplib.SMTP(smtp_server,port)
    server.ehlo()
    server.starttls(context=context) # Secure the connection
    server.ehlo()
    server.login(sender_email, password)
    #msg = "Message from the gate\n" + inp # <------TO BE SENT TO THE RESIDENT
    msg = 'Subject: {}\n\n{}'.format("Message from gate", inp)
    server.sendmail('officialpython20@gmail.com', # apartment's email 
                    em, # resident's email 
                    msg) # message
                
    server.quit
except Exception as e:
    # Print any error messages to stdout
    print('error')
finally:
    server.quit()