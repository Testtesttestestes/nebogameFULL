using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace CloudsFly
{
	// Token: 0x0200130E RID: 4878
	[Token(Token = "0x200130E")]
	public abstract class WorldObject<TArgs> : WorldObject where TArgs : WorldObjectArgs
	{
		// Token: 0x1700175F RID: 5983
		// (get) Token: 0x060073EC RID: 29676 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060073ED RID: 29677 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700175F")]
		public TArgs Args
		{
			[Token(Token = "0x60073EC")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60073ED")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060073EE RID: 29678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073EE")]
		protected override void OnInit(WorldObjectArgs args)
		{
		}

		// Token: 0x060073EF RID: 29679
		[Token(Token = "0x60073EF")]
		protected abstract void OnInit(TArgs args);

		// Token: 0x060073F0 RID: 29680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60073F0")]
		protected WorldObject()
		{
		}
	}
}
