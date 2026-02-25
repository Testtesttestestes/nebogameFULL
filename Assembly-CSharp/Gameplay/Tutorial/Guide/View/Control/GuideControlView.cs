using System;
using Il2CppDummyDll;
using TMPro;
using UI;
using UI.Tabs;
using UI.Toggle;
using UnityEngine;

namespace Gameplay.Tutorial.Guide.View.Control
{
	// Token: 0x02000470 RID: 1136
	[Token(Token = "0x2000470")]
	public class GuideControlView : MonoBehaviourWithStates<GuideControlView.GuideControlViewStates>
	{
		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004AF")]
		public GreenToggle GreenToggle
		{
			[Token(Token = "0x6001AEF")]
			[Address(RVA = "0x6C79", Offset = "0x6C79", VA = "0x6C79")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B0")]
		public TabBar TabBar
		{
			[Token(Token = "0x6001AF0")]
			[Address(RVA = "0x6C7A", Offset = "0x6C7A", VA = "0x6C7A")]
			get
			{
				return null;
			}
		}

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170004B1")]
		public TMP_Text StateDescriptionText
		{
			[Token(Token = "0x6001AF1")]
			[Address(RVA = "0x6C7B", Offset = "0x6C7B", VA = "0x6C7B")]
			get
			{
				return null;
			}
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF2")]
		[Address(RVA = "0x6C7C", Offset = "0x6C7C", VA = "0x6C7C", Slot = "4")]
		protected override void HandleCurrentStateChanged(GuideControlView.GuideControlViewStates fromState, GuideControlView.GuideControlViewStates toState)
		{
		}

		// Token: 0x06001AF3 RID: 6899 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001AF3")]
		[Address(RVA = "0x6C7D", Offset = "0x6C7D", VA = "0x6C7D")]
		public GuideControlView()
		{
		}

		// Token: 0x04000E7F RID: 3711
		[Token(Token = "0x4000E7F")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private TabBar _tabBar;

		// Token: 0x04000E80 RID: 3712
		[Token(Token = "0x4000E80")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private TMP_Text _stateDescriptionText;

		// Token: 0x04000E81 RID: 3713
		[Token(Token = "0x4000E81")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private GreenToggle _greenToggle;

		// Token: 0x02000471 RID: 1137
		[Token(Token = "0x2000471")]
		public enum GuideControlViewStates
		{
			// Token: 0x04000E83 RID: 3715
			[Token(Token = "0x4000E83")]
			DEFAULT,
			// Token: 0x04000E84 RID: 3716
			[Token(Token = "0x4000E84")]
			ENABLED_ON,
			// Token: 0x04000E85 RID: 3717
			[Token(Token = "0x4000E85")]
			ENABLED_OFF
		}
	}
}
