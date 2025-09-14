using Microsoft.AspNetCore.SignalR;

namespace betrayal_hill.Hubs
{
    public class GameHub : Hub
    {
        // This is just a placeholder method for now.
        // Clients can call it to test connectivity.
        public async Task JoinGame()
        {
            await Clients.All.SendAsync("joinGame");
        }

        public async Task RollDice(int numberOfDice)
        {
            Random rng = new();
            int[] dice = new int[numberOfDice];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = rng.Next(0, 3);
            }

            await Clients.All.SendAsync("rollResult", dice);
        }
    }
}
