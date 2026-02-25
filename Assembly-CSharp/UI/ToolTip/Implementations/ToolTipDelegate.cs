using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace UI.ToolTip.Implementations
{
	// Token: 0x0200013F RID: 319
	[Token(Token = "0x200013F")]
	[RequireComponent(typeof(ToolTip))]
	public class ToolTipDelegate : MonoBehaviour, IToolTipDataProvider
	{
		// Token: 0x140000D3 RID: 211
		// (add) Token: 0x06000998 RID: 2456 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06000999 RID: 2457 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140000D3")]
		public event Func<BaseToolTipData> TooltipDelegate
		{
			[Token(Token = "0x6000998")]
			[Address(RVA = "0x5D00", Offset = "0x5D00", VA = "0x5D00")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6000999")]
			[Address(RVA = "0x5D01", Offset = "0x5D01", VA = "0x5D01")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x0600099A RID: 2458 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099A")]
		[Address(RVA = "0x5D02", Offset = "0x5D02", VA = "0x5D02")]
		public void Init(Func<BaseToolTipData> @delegate)
		{
		}

		// Token: 0x0600099B RID: 2459 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099B")]
		[Address(RVA = "0x5D03", Offset = "0x5D03", VA = "0x5D03")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600099C RID: 2460 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600099C")]
		[Address(RVA = "0x5D04", Offset = "0x5D04", VA = "0x5D04", Slot = "4")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600099D RID: 2461 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600099D")]
		[Address(RVA = "0x5D05", Offset = "0x5D05", VA = "0x5D05")]
		public ToolTipDelegate()
		{
		}
	}
}
