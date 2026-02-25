using System;
using System.Runtime.CompilerServices;
using AssetContent;
using Gameplay.Boss.Model;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.CaptainTab
{
	// Token: 0x02000B7F RID: 2943
	[Token(Token = "0x2000B7F")]
	public class BossTeamAssistantView : MonoBehaviour
	{
		// Token: 0x140001C3 RID: 451
		// (add) Token: 0x06004776 RID: 18294 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004777 RID: 18295 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001C3")]
		public event Action<TeamData.TeamAssistantData> ClickEvent
		{
			[Token(Token = "0x6004776")]
			[Address(RVA = "0x9606", Offset = "0x9606", VA = "0x9606")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004777")]
			[Address(RVA = "0x9607", Offset = "0x9607", VA = "0x9607")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06004778 RID: 18296 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004778")]
		[Address(RVA = "0x9608", Offset = "0x9608", VA = "0x9608")]
		private void Awake()
		{
		}

		// Token: 0x06004779 RID: 18297 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6004779")]
		[Address(RVA = "0x9609", Offset = "0x9609", VA = "0x9609")]
		private void ClickHandlerOnOnClickEvent(PointerEventData obj)
		{
		}

		// Token: 0x0600477A RID: 18298 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477A")]
		[Address(RVA = "0x960A", Offset = "0x960A", VA = "0x960A")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000E4B RID: 3659
		// (get) Token: 0x0600477B RID: 18299 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600477C RID: 18300 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E4B")]
		public TeamData.TeamAssistantData AssistantData
		{
			[Token(Token = "0x600477B")]
			[Address(RVA = "0x960B", Offset = "0x960B", VA = "0x960B")]
			get
			{
				return null;
			}
			[Token(Token = "0x600477C")]
			[Address(RVA = "0x960C", Offset = "0x960C", VA = "0x960C")]
			set
			{
			}
		}

		// Token: 0x0600477D RID: 18301 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600477D")]
		[Address(RVA = "0x960D", Offset = "0x960D", VA = "0x960D")]
		public BossTeamAssistantView()
		{
		}

		// Token: 0x04002740 RID: 10048
		[Token(Token = "0x4002740")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x04002741 RID: 10049
		[Token(Token = "0x4002741")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x04002742 RID: 10050
		[Token(Token = "0x4002742")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SkillIconValue _skillBonusView;

		// Token: 0x04002743 RID: 10051
		[Token(Token = "0x4002743")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private SimpleIconValue _cultBonusView;

		// Token: 0x04002744 RID: 10052
		[Token(Token = "0x4002744")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _timeIcon;

		// Token: 0x04002745 RID: 10053
		[Token(Token = "0x4002745")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GameObject _backtimeGroup;

		// Token: 0x04002746 RID: 10054
		[Token(Token = "0x4002746")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeView;

		// Token: 0x04002747 RID: 10055
		[Token(Token = "0x4002747")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private bool _disableContextMenu;

		// Token: 0x04002749 RID: 10057
		[Token(Token = "0x4002749")]
		[FieldOffset(Offset = "0x34")]
		private TeamData.TeamAssistantData _assistantData;
	}
}
