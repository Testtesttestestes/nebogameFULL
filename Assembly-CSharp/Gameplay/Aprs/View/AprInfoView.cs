using System;
using Gameplay.Aprs.Model;
using Gameplay.Collections.View;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Requirements;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.Aprs.View
{
	// Token: 0x02000D4F RID: 3407
	[Token(Token = "0x2000D4F")]
	public class AprInfoView : MonoBehaviour
	{
		// Token: 0x170010F1 RID: 4337
		// (get) Token: 0x06005374 RID: 21364 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170010F1")]
		private string DurationPrefix
		{
			[Token(Token = "0x6005374")]
			[Address(RVA = "0xA133", Offset = "0xA133", VA = "0xA133")]
			get
			{
				return null;
			}
		}

		// Token: 0x170010F2 RID: 4338
		// (set) Token: 0x06005375 RID: 21365 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010F2")]
		public AprData AprData
		{
			[Token(Token = "0x6005375")]
			[Address(RVA = "0xA134", Offset = "0xA134", VA = "0xA134")]
			set
			{
			}
		}

		// Token: 0x06005376 RID: 21366 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005376")]
		[Address(RVA = "0xA135", Offset = "0xA135", VA = "0xA135")]
		private string FormatDuration(float rawValue)
		{
			return null;
		}

		// Token: 0x06005377 RID: 21367 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005377")]
		[Address(RVA = "0xA136", Offset = "0xA136", VA = "0xA136")]
		public AprInfoView()
		{
		}

		// Token: 0x04002D2D RID: 11565
		[Token(Token = "0x4002D2D")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x04002D2E RID: 11566
		[Token(Token = "0x4002D2E")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _desc;

		// Token: 0x04002D2F RID: 11567
		[Token(Token = "0x4002D2F")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private RewardsRender _rewardsRender;

		// Token: 0x04002D30 RID: 11568
		[Token(Token = "0x4002D30")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RequirementsView _requirementsView;

		// Token: 0x04002D31 RID: 11569
		[Token(Token = "0x4002D31")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameObject _legendaryViewStub;

		// Token: 0x04002D32 RID: 11570
		[Token(Token = "0x4002D32")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private BacktimeViewUGUI _durationLabel;

		// Token: 0x04002D33 RID: 11571
		[Token(Token = "0x4002D33")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private CollectionRowHelper _collectionRow;

		// Token: 0x04002D34 RID: 11572
		[Token(Token = "0x4002D34")]
		[FieldOffset(Offset = "0x2C")]
		private AprData _aprData;

		// Token: 0x04002D35 RID: 11573
		[Token(Token = "0x4002D35")]
		[FieldOffset(Offset = "0x30")]
		private string _durationPrefix;
	}
}
