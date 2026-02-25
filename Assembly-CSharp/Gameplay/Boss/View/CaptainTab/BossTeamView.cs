using System;
using System.Runtime.CompilerServices;
using AssetContent.Loaders;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B84 RID: 2948
	[Token(Token = "0x2000B84")]
	public class BossTeamView : MonoBehaviour
	{
		// Token: 0x140001C6 RID: 454
		// (add) Token: 0x060047A0 RID: 18336 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060047A1 RID: 18337 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C6")]
		public event Action<TeamData.TeamAssistantData> AssistantClickedEvent
		{
			[Token(Token = "0x60047A0")]
			[Address(RVA = "0x1B4B", Offset = "0x1B4B", VA = "0x1B4B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60047A1")]
			[Address(RVA = "0x962F", Offset = "0x962F", VA = "0x962F")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x060047A2 RID: 18338 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A2")]
		[Address(RVA = "0x9630", Offset = "0x9630", VA = "0x9630")]
		private void Awake()
		{
		}

		// Token: 0x060047A3 RID: 18339 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A3")]
		[Address(RVA = "0x9631", Offset = "0x9631", VA = "0x9631")]
		private void AOnClickEvent(TeamData.TeamAssistantData data)
		{
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x060047A4 RID: 18340 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047A5 RID: 18341 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E54")]
		public TeamData TeamInfoData
		{
			[Token(Token = "0x60047A4")]
			[Address(RVA = "0x9632", Offset = "0x9632", VA = "0x9632")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047A5")]
			[Address(RVA = "0x1B4C", Offset = "0x1B4C", VA = "0x1B4C")]
			set
			{
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x060047A6 RID: 18342 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x060047A7 RID: 18343 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E55")]
		public BossInfo BossInfo
		{
			[Token(Token = "0x60047A6")]
			[Address(RVA = "0x9633", Offset = "0x9633", VA = "0x9633")]
			get
			{
				return null;
			}
			[Token(Token = "0x60047A7")]
			[Address(RVA = "0x1B61", Offset = "0x1B61", VA = "0x1B61")]
			set
			{
			}
		}

		// Token: 0x060047A8 RID: 18344 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A8")]
		[Address(RVA = "0x9634", Offset = "0x9634", VA = "0x9634")]
		private void TeamInfoDataOnCaptainRatingChangedEvent()
		{
		}

		// Token: 0x060047A9 RID: 18345 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047A9")]
		[Address(RVA = "0x9635", Offset = "0x9635", VA = "0x9635")]
		private void RenderCaptainPlace()
		{
		}

		// Token: 0x060047AA RID: 18346 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AA")]
		[Address(RVA = "0x9636", Offset = "0x9636", VA = "0x9636")]
		private void OnDestroy()
		{
		}

		// Token: 0x060047AB RID: 18347 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AB")]
		[Address(RVA = "0x9637", Offset = "0x9637", VA = "0x9637")]
		private void ClickHandlerOnOnClickEvent(PointerEventData eventData)
		{
		}

		// Token: 0x060047AC RID: 18348 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60047AC")]
		[Address(RVA = "0x9638", Offset = "0x9638", VA = "0x9638")]
		public BossTeamView()
		{
		}

		// Token: 0x04002756 RID: 10070
		[Token(Token = "0x4002756")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private BossTeamAssistantView[] _assistantViews;

		// Token: 0x04002757 RID: 10071
		[Token(Token = "0x4002757")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossTeamCaptainView _captainView;

		// Token: 0x04002758 RID: 10072
		[Token(Token = "0x4002758")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002759 RID: 10073
		[Token(Token = "0x4002759")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TextMeshProUGUI _totalSkillBonusLabel;

		// Token: 0x0400275A RID: 10074
		[Token(Token = "0x400275A")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SkillIconValue _totalSkillBonus;

		// Token: 0x0400275B RID: 10075
		[Token(Token = "0x400275B")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x0400275C RID: 10076
		[Token(Token = "0x400275C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _title;

		// Token: 0x0400275D RID: 10077
		[Token(Token = "0x400275D")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _dominateCultTitle;

		// Token: 0x0400275E RID: 10078
		[Token(Token = "0x400275E")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private GameImageLoader _dominateCultIcon;

		// Token: 0x0400275F RID: 10079
		[Token(Token = "0x400275F")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private GameObject _dominateCultContainer;

		// Token: 0x04002761 RID: 10081
		[Token(Token = "0x4002761")]
		[FieldOffset(Offset = "0x3C")]
		private TeamData _teamInfoData;

		// Token: 0x04002762 RID: 10082
		[Token(Token = "0x4002762")]
		[FieldOffset(Offset = "0x40")]
		private BossInfo _bossInfo;
	}
}
