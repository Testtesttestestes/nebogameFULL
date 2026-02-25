using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace UI.Elements.GenericList
{
	// Token: 0x0200022B RID: 555
	[Token(Token = "0x200022B")]
	public class SelectableListElementArgs : GenericListElementArgs
	{
		// Token: 0x140000ED RID: 237
		// (add) Token: 0x06000DCF RID: 3535 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DD0 RID: 3536 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000ED")]
		public event Action<bool> SelectChangedEvent
		{
			[Token(Token = "0x6000DCF")]
			[Address(RVA = "0x607B", Offset = "0x607B", VA = "0x607B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DD0")]
			[Address(RVA = "0x607C", Offset = "0x607C", VA = "0x607C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x140000EE RID: 238
		// (add) Token: 0x06000DD1 RID: 3537 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000DD2 RID: 3538 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000EE")]
		public event Action DataChangedEvent
		{
			[Token(Token = "0x6000DD1")]
			[Address(RVA = "0x607D", Offset = "0x607D", VA = "0x607D")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000DD2")]
			[Address(RVA = "0x607E", Offset = "0x607E", VA = "0x607E")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06000DD3 RID: 3539 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD3")]
		[Address(RVA = "0x607F", Offset = "0x607F", VA = "0x607F")]
		public void CallDataChangedEvent()
		{
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000DD4 RID: 3540 RVA: 0x00004128 File Offset: 0x00002328
		// (set) Token: 0x06000DD5 RID: 3541 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170001D2")]
		public bool Selected
		{
			[Token(Token = "0x6000DD4")]
			[Address(RVA = "0x6080", Offset = "0x6080", VA = "0x6080")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6000DD5")]
			[Address(RVA = "0x6081", Offset = "0x6081", VA = "0x6081")]
			set
			{
			}
		}

		// Token: 0x06000DD6 RID: 3542 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000DD6")]
		[Address(RVA = "0x6082", Offset = "0x6082", VA = "0x6082")]
		public SelectableListElementArgs()
		{
		}

		// Token: 0x040006D3 RID: 1747
		[Token(Token = "0x40006D3")]
		[FieldOffset(Offset = "0xC")]
		protected bool _selected;
	}
}
