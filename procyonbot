var Discordie = require('discordie');

const Events = Discordie.Events;
const client = new Discordie();

client.connect({ token: 'Mjg0MzAxODM5NDMwODQ0NDE2.C5BoQQ.mQY2rWoVT9w3rW60uD6AGM-d58w' });

client.Dispatcher.on(Events.GATEWAY_READY, e => {
    console.log('Connected as: ' + client.User.Username);
});

client.Dispatcher.on(Events.Message_Create, e => {
    if (e.message.content == '.procyon') {
        e.message.channel.sendMessage('Merhaba Procyonlu');
    }
});
