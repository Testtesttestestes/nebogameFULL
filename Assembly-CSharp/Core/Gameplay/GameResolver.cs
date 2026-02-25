using System;
using Core.Application;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001123 RID: 4387
	[Token(Token = "0x2001123")]
	public class GameResolver : IGameResolver
	{
		// Token: 0x060066B8 RID: 26296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B8")]
		[Address(RVA = "0xB237", Offset = "0xB237", VA = "0xB237")]
		public GameResolver(IApp app)
		{
		}

		// Token: 0x060066B9 RID: 26297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066B9")]
		[Address(RVA = "0xB238", Offset = "0xB238", VA = "0xB238")]
		private void HandleGameInstanceDeinitEvent(IGame game)
		{
		}

		// Token: 0x060066BA RID: 26298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BA")]
		[Address(RVA = "0xB239", Offset = "0xB239", VA = "0xB239", Slot = "4")]
		public void Resolve(IGame game)
		{
		}

		// Token: 0x060066BB RID: 26299 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60066BB")]
		[Address(RVA = "0xB23A", Offset = "0xB23A", VA = "0xB23A", Slot = "5")]
		public void Resolve(IAuthDataProvider provider)
		{
		}

		// Token: 0x040036E9 RID: 14057
		[Token(Token = "0x40036E9")]
		[FieldOffset(Offset = "0x8")]
		private readonly IApp _app;
	}
}
