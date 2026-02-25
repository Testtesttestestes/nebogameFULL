using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip
{
	// Token: 0x0200013D RID: 317
	[Token(Token = "0x200013D")]
	public class ToolTipData<T> : BaseToolTipData
	{
		// Token: 0x06000988 RID: 2440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000988")]
		public ToolTipData(string toolTipId)
		{
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000989")]
		public ToolTipData(string toolTipId, T data)
		{
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x0600098A RID: 2442 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600098B RID: 2443 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000144")]
		public T Data
		{
			[Token(Token = "0x600098A")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600098B")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600098C")]
		public override Transform CreateContent(Transform parent)
		{
			return null;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600098D")]
		public override void Dispose()
		{
		}

		// Token: 0x04000390 RID: 912
		[Token(Token = "0x4000390")]
		[FieldOffset(Offset = "0x0")]
		private BaseToolTip<T> _originalContent;
	}
}
