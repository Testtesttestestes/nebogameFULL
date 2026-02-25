using System;
using System.Runtime.CompilerServices;
using Gameplay.Boss.Model;
using Gameplay.Boss.View.CaptainTab;
using Il2CppDummyDll;
using UI;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using Utils;

namespace Gameplay.Boss.View.InvitesTab
{
	// Token: 0x02000B6D RID: 2925
	[Token(Token = "0x2000B6D")]
	public class BossInviteItemView : MonoBehaviour
	{
		// Token: 0x140001BE RID: 446
		// (add) Token: 0x06004706 RID: 18182 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06004707 RID: 18183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x140001BE")]
		public event Action<BossInviteData> ClickEvent
		{
			[Token(Token = "0x6004706")]
			[Address(RVA = "0x959C", Offset = "0x959C", VA = "0x959C")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6004707")]
			[Address(RVA = "0x959D", Offset = "0x959D", VA = "0x959D")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x06004708 RID: 18184 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06004709 RID: 18185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E23")]
		public BossInviteData Data
		{
			[Token(Token = "0x6004708")]
			[Address(RVA = "0x959E", Offset = "0x959E", VA = "0x959E")]
			get
			{
				return null;
			}
			[Token(Token = "0x6004709")]
			[Address(RVA = "0x959F", Offset = "0x959F", VA = "0x959F")]
			set
			{
			}
		}

		// Token: 0x0600470A RID: 18186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470A")]
		[Address(RVA = "0x95A0", Offset = "0x95A0", VA = "0x95A0")]
		private void DataOnCaptainUserDataChangedEvent()
		{
		}

		// Token: 0x17000E24 RID: 3620
		// (set) Token: 0x0600470B RID: 18187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000E24")]
		public bool Selected
		{
			[Token(Token = "0x600470B")]
			[Address(RVA = "0x95A1", Offset = "0x95A1", VA = "0x95A1")]
			set
			{
			}
		}

		// Token: 0x0600470C RID: 18188 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470C")]
		[Address(RVA = "0x95A2", Offset = "0x95A2", VA = "0x95A2")]
		private void Awake()
		{
		}

		// Token: 0x0600470D RID: 18189 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470D")]
		[Address(RVA = "0x95A3", Offset = "0x95A3", VA = "0x95A3")]
		private void ClickHandlerOnOnClickEvent(PointerEventData data)
		{
		}

		// Token: 0x0600470E RID: 18190 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470E")]
		[Address(RVA = "0x95A4", Offset = "0x95A4", VA = "0x95A4")]
		private void OnDestroy()
		{
		}

		// Token: 0x0600470F RID: 18191 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600470F")]
		[Address(RVA = "0x95A5", Offset = "0x95A5", VA = "0x95A5")]
		public BossInviteItemView()
		{
		}

		// Token: 0x040026F6 RID: 9974
		[Token(Token = "0x40026F6")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickHandler;

		// Token: 0x040026F7 RID: 9975
		[Token(Token = "0x40026F7")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private BossUserListItemView _userListView;

		// Token: 0x040026F8 RID: 9976
		[Token(Token = "0x40026F8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private BacktimeViewUGUI _backtimeViewUGUI;

		// Token: 0x040026F9 RID: 9977
		[Token(Token = "0x40026F9")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _selectedImage;

		// Token: 0x040026FB RID: 9979
		[Token(Token = "0x40026FB")]
		[FieldOffset(Offset = "0x24")]
		private BossInviteData _data;
	}
}
