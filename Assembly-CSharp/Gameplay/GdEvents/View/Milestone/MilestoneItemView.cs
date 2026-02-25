using System;
using System.Runtime.CompilerServices;
using Gameplay.GdEvents.Model.Milestone;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Gameplay.GdEvents.View.Milestone
{
	// Token: 0x0200071F RID: 1823
	[Token(Token = "0x200071F")]
	public class MilestoneItemView : MonoBehaviour, IPointerClickHandler, IEventSystemHandler
	{
		// Token: 0x06002BA0 RID: 11168 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA0")]
		[Address(RVA = "0x7C37", Offset = "0x7C37", VA = "0x7C37")]
		private void OnDestroy()
		{
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06002BA1 RID: 11169 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BA2 RID: 11170 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000850")]
		public Action<MilestoneData> ClickCallback
		{
			[Token(Token = "0x6002BA1")]
			[Address(RVA = "0x7C38", Offset = "0x7C38", VA = "0x7C38")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BA2")]
			[Address(RVA = "0x7C39", Offset = "0x7C39", VA = "0x7C39")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06002BA3 RID: 11171 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002BA4 RID: 11172 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000851")]
		public MilestoneData Data
		{
			[Token(Token = "0x6002BA3")]
			[Address(RVA = "0x7C3A", Offset = "0x7C3A", VA = "0x7C3A")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002BA4")]
			[Address(RVA = "0x7C3B", Offset = "0x7C3B", VA = "0x7C3B")]
			set
			{
			}
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA5")]
		[Address(RVA = "0x7C3C", Offset = "0x7C3C", VA = "0x7C3C")]
		private void HandleDataChanged()
		{
		}

		// Token: 0x06002BA6 RID: 11174 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA6")]
		[Address(RVA = "0x7C3D", Offset = "0x7C3D", VA = "0x7C3D")]
		public void SetIndex(int itemIndex)
		{
		}

		// Token: 0x06002BA7 RID: 11175 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA7")]
		[Address(RVA = "0x7C3E", Offset = "0x7C3E", VA = "0x7C3E", Slot = "4")]
		public void OnPointerClick(PointerEventData eventData)
		{
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002BA8")]
		[Address(RVA = "0x7C3F", Offset = "0x7C3F", VA = "0x7C3F")]
		public MilestoneItemView()
		{
		}

		// Token: 0x040017E0 RID: 6112
		[Token(Token = "0x40017E0")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private TextMeshProUGUI _index;

		// Token: 0x040017E1 RID: 6113
		[Token(Token = "0x40017E1")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private TextMeshProUGUI _progressValueField;

		// Token: 0x040017E2 RID: 6114
		[Token(Token = "0x40017E2")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _description;

		// Token: 0x040017E3 RID: 6115
		[Token(Token = "0x40017E3")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private Image _background;

		// Token: 0x040017E4 RID: 6116
		[Token(Token = "0x40017E4")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private Image _progressCompleteIcon;

		// Token: 0x040017E5 RID: 6117
		[Token(Token = "0x40017E5")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Image _selector;

		// Token: 0x040017E6 RID: 6118
		[Token(Token = "0x40017E6")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private MilestoneItemView.BgConfig[] _bgConfigs;

		// Token: 0x040017E8 RID: 6120
		[Token(Token = "0x40017E8")]
		[FieldOffset(Offset = "0x30")]
		private MilestoneData _data;

		// Token: 0x02000720 RID: 1824
		[Token(Token = "0x2000720")]
		[Serializable]
		public class BgConfig
		{
			// Token: 0x06002BA9 RID: 11177 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002BA9")]
			[Address(RVA = "0x7C40", Offset = "0x7C40", VA = "0x7C40")]
			public BgConfig()
			{
			}

			// Token: 0x040017E9 RID: 6121
			[Token(Token = "0x40017E9")]
			[FieldOffset(Offset = "0x8")]
			public MilestoneProgressState _state;

			// Token: 0x040017EA RID: 6122
			[Token(Token = "0x40017EA")]
			[FieldOffset(Offset = "0xC")]
			public Sprite _sprite;
		}
	}
}
