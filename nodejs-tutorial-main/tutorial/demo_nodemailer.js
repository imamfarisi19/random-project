var nodemailer = require('nodemailer');

var transporter = nodemailer.createTransport({
  service: 'gmail',
  auth: {
    user: 'syoryuken128@gmail.com',
    pass: 'SakuraS0drag0n'
  }
});

var mailOptions = {
  from: 'syoryuken128@gmail.com',
  to: 'crackwall80@gmail.com',
  subject: 'Sending Email using Node.js',
  text: 'That was easy!'
};

transporter.sendMail(mailOptions, function(error, info){
  if (error) {
    console.log(error);
  } else {
    console.log('Email sent: ' + info.response);
  }
});
