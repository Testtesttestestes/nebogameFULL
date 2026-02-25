using System;
using Gameplay.Boss.Controller;
using Gameplay.Boss.Events;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI.Windows;

namespace Gameplay.Boss.View.ListView
{
	// Token: 0x02000B6C RID: 2924
	[Token(Token = "0x2000B6C")]
	public class BossListWindowArgs : BaseWindowArgs
	{
		// Token: 0x06004705 RID: 18181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004705")]
		[Address(RVA = "0x959B", Offset = "0x959B", VA = "0x959B")]
		public BossListWindowArgs()
		{
		}

		// Token: 0x040026F3 RID: 9971
		[Token(Token = "0x40026F3")]
		[FieldOffset(Offset = "0x18")]
		public BossController Controller;

		// Token: 0x040026F4 RID: 9972
		[Token(Token = "0x40026F4")]
		[FieldOffset(Offset = "0x1C")]
		public BossEvents Events;

		// Token: 0x040026F5 RID: 9973
		[Token(Token = "0x40026F5")]
		[FieldOffset(Offset = "0x20")]
		public BossModel Model;
	}
}
