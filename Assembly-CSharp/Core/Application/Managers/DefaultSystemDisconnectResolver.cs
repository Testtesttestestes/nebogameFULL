using System;
using System.Runtime.CompilerServices;
using Core.Application.Managers.Connection;
using Core.Gameplay;
using Il2CppDummyDll;
using Protocol.System;

namespace Core.Application.Managers
{
	// Token: 0x0200124E RID: 4686
	[Token(Token = "0x200124E")]
	public class DefaultSystemDisconnectResolver : ISystemDisconnectResolver
	{
		// Token: 0x170016AF RID: 5807
		// (get) Token: 0x06006F0F RID: 28431 RVA: 0x00014418 File Offset: 0x00012618
		// (set) Token: 0x06006F10 RID: 28432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170016AF")]
		public DisconnectCode? Code
		{
			[Token(Token = "0x6006F0F")]
			[Address(RVA = "0xB98B", Offset = "0xB98B", VA = "0xB98B", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6006F10")]
			[Address(RVA = "0xB98C", Offset = "0xB98C", VA = "0xB98C", Slot = "5")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F11")]
		[Address(RVA = "0xB98D", Offset = "0xB98D", VA = "0xB98D")]
		public DefaultSystemDisconnectResolver(IGameRestart gameRestart)
		{
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x00014430 File Offset: 0x00012630
		[Token(Token = "0x6006F12")]
		[Address(RVA = "0xB98E", Offset = "0xB98E", VA = "0xB98E")]
		public bool IsReConnectAllowed(DisconnectCode? code)
		{
			return default(bool);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F13")]
		[Address(RVA = "0xB98F", Offset = "0xB98F", VA = "0xB98F", Slot = "6")]
		public void Resolve(IConnectionManage connection)
		{
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x00014448 File Offset: 0x00012648
		[Token(Token = "0x6006F14")]
		[Address(RVA = "0xB990", Offset = "0xB990", VA = "0xB990", Slot = "7")]
		public bool TryNotify()
		{
			return default(bool);
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006F15")]
		[Address(RVA = "0xB991", Offset = "0xB991", VA = "0xB991")]
		private void ShowAlert(string description)
		{
		}

		// Token: 0x04003A08 RID: 14856
		[Token(Token = "0x4003A08")]
		[FieldOffset(Offset = "0x8")]
		private readonly IGameRestart _gameRestart;
	}
}
