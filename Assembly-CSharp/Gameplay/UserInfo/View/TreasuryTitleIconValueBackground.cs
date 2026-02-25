using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.ToolTip;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.UserInfo.View
{
	// Token: 0x02000400 RID: 1024
	[Token(Token = "0x2000400")]
	public class TreasuryTitleIconValueBackground : TitleIconValueBackground, IToolTipDataProvider
	{
		// Token: 0x14000117 RID: 279
		// (add) Token: 0x06001810 RID: 6160 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001811 RID: 6161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000117")]
		public event Action ClickEvent
		{
			[Token(Token = "0x6001810")]
			[Address(RVA = "0x69C7", Offset = "0x69C7", VA = "0x69C7")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001811")]
			[Address(RVA = "0x4462", Offset = "0x4462", VA = "0x4462")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000118 RID: 280
		// (add) Token: 0x06001812 RID: 6162 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06001813 RID: 6163 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000118")]
		public event Func<Protocol.Consts.Resources, BaseToolTipData> GetTooltipData
		{
			[Token(Token = "0x6001812")]
			[Address(RVA = "0x69C8", Offset = "0x69C8", VA = "0x69C8")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6001813")]
			[Address(RVA = "0x4463", Offset = "0x4463", VA = "0x4463")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06001814 RID: 6164 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001814")]
		[Address(RVA = "0x69C9", Offset = "0x69C9", VA = "0x69C9")]
		public void SetResourceId(Protocol.Consts.Resources resourceId)
		{
		}

		// Token: 0x17000433 RID: 1075
		// (set) Token: 0x06001815 RID: 6165 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000433")]
		public bool Marked
		{
			[Token(Token = "0x6001815")]
			[Address(RVA = "0x4465", Offset = "0x4465", VA = "0x4465")]
			set
			{
			}
		}

		// Token: 0x06001816 RID: 6166 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001816")]
		[Address(RVA = "0x69CA", Offset = "0x69CA", VA = "0x69CA")]
		private void Awake()
		{
		}

		// Token: 0x06001817 RID: 6167 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001817")]
		[Address(RVA = "0x69CB", Offset = "0x69CB", VA = "0x69CB")]
		private void OnDestroy()
		{
		}

		// Token: 0x06001818 RID: 6168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001818")]
		[Address(RVA = "0x69CC", Offset = "0x69CC", VA = "0x69CC")]
		private void MarkerClickedEventHandler()
		{
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6001819")]
		[Address(RVA = "0x69CD", Offset = "0x69CD", VA = "0x69CD", Slot = "6")]
		public BaseToolTipData GetData()
		{
			return null;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600181A")]
		[Address(RVA = "0x69CE", Offset = "0x69CE", VA = "0x69CE")]
		public TreasuryTitleIconValueBackground()
		{
		}

		// Token: 0x04000CCC RID: 3276
		[Token(Token = "0x4000CCC")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Button _marker;

		// Token: 0x04000CCF RID: 3279
		[Token(Token = "0x4000CCF")]
		[FieldOffset(Offset = "0x44")]
		private Protocol.Consts.Resources _resourceId;
	}
}
