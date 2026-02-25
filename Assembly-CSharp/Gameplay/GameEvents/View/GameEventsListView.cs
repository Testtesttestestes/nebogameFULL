using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Model;
using Gameplay.GameEvents.View.Lists;
using Il2CppDummyDll;
using UI;
using UI.Tabs;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.GameEvents.View
{
	// Token: 0x0200077C RID: 1916
	[Token(Token = "0x200077C")]
	public class GameEventsListView : MonoBehaviourWithStates<GameEventsListView.GameEventsListViewStates>
	{
		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x06002D99 RID: 11673 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C2")]
		public Toggle SelectAll
		{
			[Token(Token = "0x6002D99")]
			[Address(RVA = "0x7E17", Offset = "0x7E17", VA = "0x7E17")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x06002D9A RID: 11674 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C3")]
		public Button DeleteButton
		{
			[Token(Token = "0x6002D9A")]
			[Address(RVA = "0x7E18", Offset = "0x7E18", VA = "0x7E18")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x06002D9B RID: 11675 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C4")]
		public Button CancelEditMode
		{
			[Token(Token = "0x6002D9B")]
			[Address(RVA = "0x7E19", Offset = "0x7E19", VA = "0x7E19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x06002D9C RID: 11676 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008C5")]
		public TabBar TabBar
		{
			[Token(Token = "0x6002D9C")]
			[Address(RVA = "0x7E1A", Offset = "0x7E1A", VA = "0x7E1A")]
			get
			{
				return null;
			}
		}

		// Token: 0x14000165 RID: 357
		// (add) Token: 0x06002D9D RID: 11677 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06002D9E RID: 11678 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x14000165")]
		public event Action<GameEventsListView> OnReady
		{
			[Token(Token = "0x6002D9D")]
			[Address(RVA = "0x7E1B", Offset = "0x7E1B", VA = "0x7E1B")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6002D9E")]
			[Address(RVA = "0x7E1C", Offset = "0x7E1C", VA = "0x7E1C")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x06002D9F RID: 11679 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002D9F")]
		[Address(RVA = "0x7E1D", Offset = "0x7E1D", VA = "0x7E1D")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA0")]
		[Address(RVA = "0x7E1E", Offset = "0x7E1E", VA = "0x7E1E")]
		private void Awake()
		{
		}

		// Token: 0x06002DA1 RID: 11681 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA1")]
		[Address(RVA = "0x7E1F", Offset = "0x7E1F", VA = "0x7E1F")]
		private void HandleListAdapterInit()
		{
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x06002DA2 RID: 11682 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06002DA3 RID: 11683 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008C6")]
		public List<GameEventsListView.GameEventsListItemWrapper> Events
		{
			[Token(Token = "0x6002DA2")]
			[Address(RVA = "0x7E20", Offset = "0x7E20", VA = "0x7E20")]
			get
			{
				return null;
			}
			[Token(Token = "0x6002DA3")]
			[Address(RVA = "0x7E21", Offset = "0x7E21", VA = "0x7E21")]
			set
			{
			}
		}

		// Token: 0x06002DA4 RID: 11684 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA4")]
		[Address(RVA = "0x7E22", Offset = "0x7E22", VA = "0x7E22")]
		private void HandleEventsChanges()
		{
		}

		// Token: 0x06002DA5 RID: 11685 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA5")]
		[Address(RVA = "0x7E23", Offset = "0x7E23", VA = "0x7E23")]
		private void ValidateEmptyList()
		{
		}

		// Token: 0x06002DA6 RID: 11686 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA6")]
		[Address(RVA = "0x7E24", Offset = "0x7E24", VA = "0x7E24")]
		public void RemoveEvents(List<int> indexes)
		{
		}

		// Token: 0x06002DA7 RID: 11687 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA7")]
		[Address(RVA = "0x7E25", Offset = "0x7E25", VA = "0x7E25")]
		public void RemoveEvent(int index)
		{
		}

		// Token: 0x06002DA8 RID: 11688 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002DA8")]
		[Address(RVA = "0x7E26", Offset = "0x7E26", VA = "0x7E26")]
		public GameEventsListView()
		{
		}

		// Token: 0x040018FE RID: 6398
		[Token(Token = "0x40018FE")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x040018FF RID: 6399
		[Token(Token = "0x40018FF")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private GameEventsListAdapter _listAdapter;

		// Token: 0x04001900 RID: 6400
		[Token(Token = "0x4001900")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Toggle _selectAll;

		// Token: 0x04001901 RID: 6401
		[Token(Token = "0x4001901")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private Button _deleteButton;

		// Token: 0x04001902 RID: 6402
		[Token(Token = "0x4001902")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private Button _cancelEditMode;

		// Token: 0x04001903 RID: 6403
		[Token(Token = "0x4001903")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private Transform[] _listIsEmptyItems;

		// Token: 0x04001904 RID: 6404
		[Token(Token = "0x4001904")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private Transform[] _listIsNotEmptyItems;

		// Token: 0x04001906 RID: 6406
		[Token(Token = "0x4001906")]
		[FieldOffset(Offset = "0x3C")]
		private List<GameEventsListView.GameEventsListItemWrapper> _eventWrappers;

		// Token: 0x0200077D RID: 1917
		[Token(Token = "0x200077D")]
		public class GameEventsListItemWrapper : IDisposable
		{
			// Token: 0x06002DA9 RID: 11689 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DA9")]
			[Address(RVA = "0x7E27", Offset = "0x7E27", VA = "0x7E27", Slot = "1")]
			protected override void Finalize()
			{
			}

			// Token: 0x06002DAA RID: 11690 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DAA")]
			[Address(RVA = "0x7E28", Offset = "0x7E28", VA = "0x7E28", Slot = "4")]
			public void Dispose()
			{
			}

			// Token: 0x170008C7 RID: 2247
			// (get) Token: 0x06002DAB RID: 11691 RVA: 0x00008CE8 File Offset: 0x00006EE8
			// (set) Token: 0x06002DAC RID: 11692 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008C7")]
			public bool IsEditMode
			{
				[Token(Token = "0x6002DAB")]
				[Address(RVA = "0x7E29", Offset = "0x7E29", VA = "0x7E29")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002DAC")]
				[Address(RVA = "0x7E2A", Offset = "0x7E2A", VA = "0x7E2A")]
				set
				{
				}
			}

			// Token: 0x14000166 RID: 358
			// (add) Token: 0x06002DAD RID: 11693 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06002DAE RID: 11694 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000166")]
			public event Action OnEditModeChanged
			{
				[Token(Token = "0x6002DAD")]
				[Address(RVA = "0x7E2B", Offset = "0x7E2B", VA = "0x7E2B")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6002DAE")]
				[Address(RVA = "0x7E2C", Offset = "0x7E2C", VA = "0x7E2C")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x14000167 RID: 359
			// (add) Token: 0x06002DAF RID: 11695 RVA: 0x00002050 File Offset: 0x00000250
			// (remove) Token: 0x06002DB0 RID: 11696 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x14000167")]
			public event Action OnSelectedChanged
			{
				[Token(Token = "0x6002DAF")]
				[Address(RVA = "0x7E2D", Offset = "0x7E2D", VA = "0x7E2D")]
				[CompilerGenerated]
				add
				{
				}
				[Token(Token = "0x6002DB0")]
				[Address(RVA = "0x7E2E", Offset = "0x7E2E", VA = "0x7E2E")]
				[CompilerGenerated]
				remove
				{
				}
			}

			// Token: 0x170008C8 RID: 2248
			// (get) Token: 0x06002DB1 RID: 11697 RVA: 0x00008D00 File Offset: 0x00006F00
			// (set) Token: 0x06002DB2 RID: 11698 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170008C8")]
			public bool Selected
			{
				[Token(Token = "0x6002DB1")]
				[Address(RVA = "0x7E2F", Offset = "0x7E2F", VA = "0x7E2F")]
				get
				{
					return default(bool);
				}
				[Token(Token = "0x6002DB2")]
				[Address(RVA = "0x7E30", Offset = "0x7E30", VA = "0x7E30")]
				set
				{
				}
			}

			// Token: 0x06002DB3 RID: 11699 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6002DB3")]
			[Address(RVA = "0x7E31", Offset = "0x7E31", VA = "0x7E31")]
			public GameEventsListItemWrapper()
			{
			}

			// Token: 0x04001907 RID: 6407
			[Token(Token = "0x4001907")]
			[FieldOffset(Offset = "0x8")]
			private bool _isEditMode;

			// Token: 0x0400190A RID: 6410
			[Token(Token = "0x400190A")]
			[FieldOffset(Offset = "0x14")]
			private bool _selected;

			// Token: 0x0400190B RID: 6411
			[Token(Token = "0x400190B")]
			[FieldOffset(Offset = "0x18")]
			public GameEventData EvtData;

			// Token: 0x0400190C RID: 6412
			[Token(Token = "0x400190C")]
			[FieldOffset(Offset = "0x1C")]
			public EventHandler<GameEventData> ItemClickHandler;

			// Token: 0x0400190D RID: 6413
			[Token(Token = "0x400190D")]
			[FieldOffset(Offset = "0x20")]
			public EventHandler<GameEventsListView.GameEventsListItemWrapper> SelectHandler;
		}

		// Token: 0x0200077E RID: 1918
		[Token(Token = "0x200077E")]
		public enum GameEventsListViewStates
		{
			// Token: 0x0400190F RID: 6415
			[Token(Token = "0x400190F")]
			UNKNOWN,
			// Token: 0x04001910 RID: 6416
			[Token(Token = "0x4001910")]
			DEFAULT,
			// Token: 0x04001911 RID: 6417
			[Token(Token = "0x4001911")]
			EDIT
		}
	}
}
