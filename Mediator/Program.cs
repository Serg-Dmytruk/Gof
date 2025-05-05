using Mediator;

var chatRoom = new ChatRoom();

var user1 = new RegularUser("Alice");
var user2 = new RegularUser("Bob");
var admin = new AdminUser("Charlie");

chatRoom.AddUser(user1);
chatRoom.AddUser(user2);
chatRoom.AddUser(admin);

admin.Send("Welcome to everybody!");
user1.Send("Hello everyone!");
user2.Send("Hi how are you?");
user1.Send("I'm good thank you!");


admin.BroadcastAlert("Keep it friendly guys!");