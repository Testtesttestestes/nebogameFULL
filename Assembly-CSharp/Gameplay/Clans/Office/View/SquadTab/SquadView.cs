using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Balance;
using Gameplay.Clans.Office.Model;
using Il2CppDummyDll;
using Protocol.Dic;
using TMPro;
using UI;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.Clans.Office.View.SquadTab
{
	// Token: 0x02000A12 RID: 2578
	[Token(Token = "0x2000A12")]
	public class SquadView : MonoBehaviourWithStates<SquadView.State>
	{
		// Token: 0x14000195 RID: 405
		// (add) Token: 0x06003D43 RID: 15683 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D44 RID: 15684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000195")]
		public event Action<MemberSlotView, SquadListElement> JoinButtonClickedEvent
		{
			[Token(Token = "0x6003D43")]
			[Address(RVA = "0x8C03", Offset = "0x8C03", VA = "0x8C03")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D44")]
			[Address(RVA = "0x8C04", Offset = "0x8C04", VA = "0x8C04")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000196 RID: 406
		// (add) Token: 0x06003D45 RID: 15685 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D46 RID: 15686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000196")]
		public event Action<MemberSlotView, SquadListElement> CrossButtonClickedEvent
		{
			[Token(Token = "0x6003D45")]
			[Address(RVA = "0x8C05", Offset = "0x8C05", VA = "0x8C05")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D46")]
			[Address(RVA = "0x8C06", Offset = "0x8C06", VA = "0x8C06")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x14000197 RID: 407
		// (add) Token: 0x06003D47 RID: 15687 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003D48 RID: 15688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000197")]
		public event Action RentButtonClickedEvent
		{
			[Token(Token = "0x6003D47")]
			[Address(RVA = "0x8C07", Offset = "0x8C07", VA = "0x8C07")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003D48")]
			[Address(RVA = "0x8C08", Offset = "0x8C08", VA = "0x8C08")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000C1E RID: 3102
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C1E")]
		public TextMeshProUGUI Class
		{
			[Token(Token = "0x6003D49")]
			[Address(RVA = "0x8C09", Offset = "0x8C09", VA = "0x8C09")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C1F RID: 3103
		// (get) Token: 0x06003D4A RID: 15690 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C1F")]
		public TextMeshProUGUI Squad
		{
			[Token(Token = "0x6003D4A")]
			[Address(RVA = "0x8C0A", Offset = "0x8C0A", VA = "0x8C0A")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C20 RID: 3104
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C20")]
		public TextMeshProUGUI MembersInClan
		{
			[Token(Token = "0x6003D4B")]
			[Address(RVA = "0x8C0B", Offset = "0x8C0B", VA = "0x8C0B")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C21 RID: 3105
		// (get) Token: 0x06003D4C RID: 15692 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C21")]
		public TextMeshProUGUI MembersInSquads
		{
			[Token(Token = "0x6003D4C")]
			[Address(RVA = "0x8C0C", Offset = "0x8C0C", VA = "0x8C0C")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C22 RID: 3106
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C22")]
		public TextMeshProUGUI PlacesAvailable
		{
			[Token(Token = "0x6003D4D")]
			[Address(RVA = "0x8C0D", Offset = "0x8C0D", VA = "0x8C0D")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C23 RID: 3107
		// (get) Token: 0x06003D4E RID: 15694 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C23")]
		public TextMeshProUGUI SeasonStatus
		{
			[Token(Token = "0x6003D4E")]
			[Address(RVA = "0x8C0E", Offset = "0x8C0E", VA = "0x8C0E")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C24")]
		public BacktimeViewUGUI SeasonBacktime
		{
			[Token(Token = "0x6003D4F")]
			[Address(RVA = "0x8C0F", Offset = "0x8C0F", VA = "0x8C0F")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x06003D50 RID: 15696 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000C25")]
		public Toggle RulesToggle
		{
			[Token(Token = "0x6003D50")]
			[Address(RVA = "0x8C10", Offset = "0x8C10", VA = "0x8C10")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x8C11", Offset = "0x8C11", VA = "0x8C11")]
		private void Awake()
		{
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x8C12", Offset = "0x8C12", VA = "0x8C12")]
		private void OnDestroy()
		{
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x8C13", Offset = "0x8C13", VA = "0x8C13")]
		private void ToggleObjects(bool enable)
		{
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x8C14", Offset = "0x8C14", VA = "0x8C14")]
		public void Init(IList<ColossusPartiesInfoDic> partyDics, IList<SquadModel.PartyData> parties, IList<ColossusSlotsInfoDic> slotDics, IBalanceSource treasury)
		{
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x8C15", Offset = "0x8C15", VA = "0x8C15")]
		private void RentButtonClickedEventHandler()
		{
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D56")]
		[Address(RVA = "0x8C16", Offset = "0x8C16", VA = "0x8C16")]
		private void JoinButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x8C17", Offset = "0x8C17", VA = "0x8C17")]
		private void CrossButtonClickedEventHandler(MemberSlotView slot, SquadListElement squad)
		{
		}

		// Token: 0x06003D58 RID: 15704 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D58")]
		[Address(RVA = "0x8C18", Offset = "0x8C18", VA = "0x8C18")]
		public SquadView()
		{
		}

		// Token: 0x04002217 RID: 8727
		[Token(Token = "0x4002217")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private RectTransform _content;

		// Token: 0x04002218 RID: 8728
		[Token(Token = "0x4002218")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SquadListElement _partyPrefab;

		// Token: 0x04002219 RID: 8729
		[Token(Token = "0x4002219")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private TextMeshProUGUI _class;

		// Token: 0x0400221A RID: 8730
		[Token(Token = "0x400221A")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private TextMeshProUGUI _squad;

		// Token: 0x0400221B RID: 8731
		[Token(Token = "0x400221B")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private TextMeshProUGUI _membersInClan;

		// Token: 0x0400221C RID: 8732
		[Token(Token = "0x400221C")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private TextMeshProUGUI _membersInSquads;

		// Token: 0x0400221D RID: 8733
		[Token(Token = "0x400221D")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private TextMeshProUGUI _placesAvailable;

		// Token: 0x0400221E RID: 8734
		[Token(Token = "0x400221E")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		private Toggle _rulesToggle;

		// Token: 0x0400221F RID: 8735
		[Token(Token = "0x400221F")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private TextMeshProUGUI _seasonStatus;

		// Token: 0x04002220 RID: 8736
		[Token(Token = "0x4002220")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private BacktimeViewUGUI _seasonBacktime;

		// Token: 0x04002221 RID: 8737
		[Token(Token = "0x4002221")]
		[FieldOffset(Offset = "0x44")]
		private SquadListElement[] _parties;

		// Token: 0x04002222 RID: 8738
		[Token(Token = "0x4002222")]
		[FieldOffset(Offset = "0x48")]
		private SquadView.State _savedState;

		// Token: 0x02000A13 RID: 2579
		[Token(Token = "0x2000A13")]
		public enum State
		{
			// Token: 0x04002227 RID: 8743
			[Token(Token = "0x4002227")]
			UNKNOWN_STATE,
			// Token: 0x04002228 RID: 8744
			[Token(Token = "0x4002228")]
			DEFAULT,
			// Token: 0x04002229 RID: 8745
			[Token(Token = "0x4002229")]
			EMPTY
		}
	}
}
