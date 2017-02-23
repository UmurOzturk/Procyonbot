var Discordie = require('discordie');

const Events = Discordie.Events;
const client = new Discordie();

client.connect({ token: 'Mjg0MzEyMjEwMTMyNDM0OTQ0.C5ByBA.Da6i6VJYtWrSeCbroMcokwBhtv8' });

client.Dispatcher.on(Events.GATEWAY_READY, e => {
    console.log('Connected as: ' + client.User.Username);
});

client.Dispatcher.on(Events.Message_Create, e => {
    if (e.message.content == '.procyon') {
        e.message.channel.sendMessage('Merhaba Procyonlu');
    }
});
