using System;
using Core.Application;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001124 RID: 4388
	[Token(Token = "0x2001124")]
	public class GameRestart : IGameRestart
	{
		// Token: 0x060066BC RID: 26300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BC")]
		[Address(RVA = "0xB23B", Offset = "0xB23B", VA = "0xB23B")]
		public GameRestart(IApp app)
		{
		}

		// Token: 0x060066BD RID: 26301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BD")]
		[Address(RVA = "0xB23C", Offset = "0xB23C", VA = "0xB23C")]
		private void GameDeinitCompleteEvent(IGame game)
		{
		}

		// Token: 0x060066BE RID: 26302 RVA: 0x00013770 File Offset: 0x00011970
		[Token(Token = "0x60066BE")]
		[Address(RVA = "0xB23D", Offset = "0xB23D", VA = "0xB23D", Slot = "4")]
		public UniTask Restart(IGame game)
		{
			return default(UniTask);
		}

		// Token: 0x040036EA RID: 14058
		[Token(Token = "0x40036EA")]
		[FieldOffset(Offset = "0x8")]
		private readonly IApp _app;

		// Token: 0x040036EB RID: 14059
		[Token(Token = "0x40036EB")]
		[FieldOffset(Offset = "0xC")]
		private UniTaskCompletionSource _cs;
	}
}
