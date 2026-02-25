using System;
using System.Collections.Generic;
using Core.Data;
using Gameplay.WorldAxis.ClanEquipment.Controller;
using Gameplay.WorldAxis.ClanEquipment.Events;
using Gameplay.WorldAxis.ClanEquipment.Model;
using Il2CppDummyDll;
using UI.Elements.Filters.GenericFilter;
using UI.Windows;
using UnityEngine;
using UnityEngine.UI;

namespace Gameplay.WorldAxis.ClanEquipment.View
{
	// Token: 0x02000341 RID: 833
	[Token(Token = "0x2000341")]
	public class ClanEquipmentWindow : ClosableBaseWindow<ClanEquipmentWindow.ClanEquipmentWindowArgs>
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x0600132E RID: 4910 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000300")]
		public override string WindowId
		{
			[Token(Token = "0x600132E")]
			[Address(RVA = "0x651F", Offset = "0x651F", VA = "0x651F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x0600132F RID: 4911 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000301")]
		public EquipmentInfoBox InfoBox
		{
			[Token(Token = "0x600132F")]
			[Address(RVA = "0x6520", Offset = "0x6520", VA = "0x6520")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06001330 RID: 4912 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000302")]
		public Button TakeOffAllButton
		{
			[Token(Token = "0x6001330")]
			[Address(RVA = "0x6521", Offset = "0x6521", VA = "0x6521")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06001331 RID: 4913 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000303")]
		public Button ExpellButton
		{
			[Token(Token = "0x6001331")]
			[Address(RVA = "0x6522", Offset = "0x6522", VA = "0x6522")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06001332 RID: 4914 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000304")]
		public DeselectableGenericFilterView Filter
		{
			[Token(Token = "0x6001332")]
			[Address(RVA = "0x6523", Offset = "0x6523", VA = "0x6523")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001333 RID: 4915 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000305")]
		public Toggle OnlyEquippedToggle
		{
			[Token(Token = "0x6001333")]
			[Address(RVA = "0x6524", Offset = "0x6524", VA = "0x6524")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001334 RID: 4916 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001334")]
		[Address(RVA = "0x6525", Offset = "0x6525", VA = "0x6525", Slot = "22")]
		protected override void OnShow(ClanEquipmentWindow.ClanEquipmentWindowArgs args)
		{
		}

		// Token: 0x06001335 RID: 4917 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001335")]
		[Address(RVA = "0x6526", Offset = "0x6526", VA = "0x6526", Slot = "19")]
		protected override void OnClose()
		{
		}

		// Token: 0x06001336 RID: 4918 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001336")]
		[Address(RVA = "0x6527", Offset = "0x6527", VA = "0x6527")]
		public void Init(IList<ClanMemberDollsListElement.ClanMemberDollsListElementArgs> items)
		{
		}

		// Token: 0x06001337 RID: 4919 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001337")]
		[Address(RVA = "0x6528", Offset = "0x6528", VA = "0x6528")]
		private void SetupMVC()
		{
		}

		// Token: 0x06001338 RID: 4920 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001338")]
		[Address(RVA = "0x6529", Offset = "0x6529", VA = "0x6529")]
		private void DestroyMVC()
		{
		}

		// Token: 0x06001339 RID: 4921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001339")]
		[Address(RVA = "0x652A", Offset = "0x652A", VA = "0x652A")]
		public ClanEquipmentWindow()
		{
		}

		// Token: 0x04000A3D RID: 2621
		[Token(Token = "0x4000A3D")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/WorldAxis/ClanEquipmentWindow";

		// Token: 0x04000A3E RID: 2622
		[Token(Token = "0x4000A3E")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private ClanMemberDollsOSAView _osaView;

		// Token: 0x04000A3F RID: 2623
		[Token(Token = "0x4000A3F")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private EquipmentInfoBox _infoBox;

		// Token: 0x04000A40 RID: 2624
		[Token(Token = "0x4000A40")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private Button _takeOffAllButton;

		// Token: 0x04000A41 RID: 2625
		[Token(Token = "0x4000A41")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private Button _expellButton;

		// Token: 0x04000A42 RID: 2626
		[Token(Token = "0x4000A42")]
		[FieldOffset(Offset = "0x4C")]
		[SerializeField]
		private DeselectableGenericFilterView _filter;

		// Token: 0x04000A43 RID: 2627
		[Token(Token = "0x4000A43")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		private Toggle _onlyEquippedToggle;

		// Token: 0x04000A44 RID: 2628
		[Token(Token = "0x4000A44")]
		[FieldOffset(Offset = "0x54")]
		private ClanEquipmentModel _model;

		// Token: 0x04000A45 RID: 2629
		[Token(Token = "0x4000A45")]
		[FieldOffset(Offset = "0x58")]
		private ClanEquipmentEvents _events;

		// Token: 0x04000A46 RID: 2630
		[Token(Token = "0x4000A46")]
		[FieldOffset(Offset = "0x5C")]
		private ClanEquipmentController _controller;

		// Token: 0x04000A47 RID: 2631
		[Token(Token = "0x4000A47")]
		[FieldOffset(Offset = "0x60")]
		private ClanEquipmentViewMediator _mediator;

		// Token: 0x02000342 RID: 834
		[Token(Token = "0x2000342")]
		public class ClanEquipmentWindowArgs : BaseWindowArgs
		{
			// Token: 0x0600133A RID: 4922 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600133A")]
			[Address(RVA = "0x652B", Offset = "0x652B", VA = "0x652B")]
			public ClanEquipmentWindowArgs()
			{
			}

			// Token: 0x04000A48 RID: 2632
			[Token(Token = "0x4000A48")]
			[FieldOffset(Offset = "0x18")]
			public UserData User;

			// Token: 0x04000A49 RID: 2633
			[Token(Token = "0x4000A49")]
			[FieldOffset(Offset = "0x1C")]
			public UserData GolemUserData;

			// Token: 0x04000A4A RID: 2634
			[Token(Token = "0x4000A4A")]
			[FieldOffset(Offset = "0x20")]
			public ulong? SelectedUserId;
		}
	}
}
