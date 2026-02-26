using System;
using AssetContent;
using Gameplay.Clans.Buildings.Golem.Controller;
using Il2CppDummyDll;
using UI.Elements.RightPanel;
using UI.Windows;
using UnityEngine;

namespace Gameplay.Clans.Buildings.Golem.View
{
	// Token: 0x02000AD0 RID: 2768
	[Token(Token = "0x2000AD0")]
	public class WarStatusWindow : ClosableBaseWindow<WarStatusWindow.WarStatusWindowArgs>
	{
		// Token: 0x17000D29 RID: 3369
		// (get) Token: 0x060042AB RID: 17067 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D29")]
		public override string WindowId
		{
			[Token(Token = "0x60042AB")]
			[Address(RVA = "0x915F", Offset = "0x915F", VA = "0x915F", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2A RID: 3370
		// (get) Token: 0x060042AC RID: 17068 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2A")]
		public TitleWithLevel TitleGroup
		{
			[Token(Token = "0x60042AC")]
			[Address(RVA = "0x9160", Offset = "0x9160", VA = "0x9160")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2B RID: 3371
		// (get) Token: 0x060042AD RID: 17069 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2B")]
		public TruceStatusView TruceStatusView
		{
			[Token(Token = "0x60042AD")]
			[Address(RVA = "0x9161", Offset = "0x9161", VA = "0x9161")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000D2C RID: 3372
		// (get) Token: 0x060042AE RID: 17070 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000D2C")]
		public WarStatusView WarStatusView
		{
			[Token(Token = "0x60042AE")]
			[Address(RVA = "0x9162", Offset = "0x9162", VA = "0x9162")]
			get
			{
				return null;
			}
		}

		// Token: 0x060042AF RID: 17071 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042AF")]
		[Address(RVA = "0x9163", Offset = "0x9163", VA = "0x9163", Slot = "22")]
		protected override void OnShow(WarStatusWindow.WarStatusWindowArgs args)
		{
		/* --- GHIDRA: OnShow ---
		void Gameplay_Clans_Buildings_Golem_View_WarStatusWindow__OnShow(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  if (DAT_ram_00a57853 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_WarStatusWindow_WarStatusWindowArgs__OnClose__)
		    ;
		    DAT_ram_00a57853 = '\x01';
		  }
		  iVar1 = **(int **)(param1 + 0x4c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x4c),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined4 *)(param1 + 0x4c) = 0;
		  UI_Windows_ClosableBaseWindow_object___OnClickBack
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_WarStatusWindow_WarStatusWindowArgs__OnClose__);
		  return;
		}
		*/

		}

		// Token: 0x060042B0 RID: 17072 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B0")]
		[Address(RVA = "0x9164", Offset = "0x9164", VA = "0x9164", Slot = "19")]
		protected override void OnClose()
		{
		/* --- GHIDRA: OnClose ---
		void Gameplay_Clans_Buildings_Golem_View_WarStatusWindow__OnClose
		               (undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a57854 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_WarStatusWindow_WarStatusWindowArgs___ctor__);
		    DAT_ram_00a57854 = '\x01';
		  }
		  UI_MonoBehaviourWithStates_ClientStateChangedDelegate___Il2CppFullySharedGenericStructType___Invoke
		            (param1,
		             Method_UI_Windows_ClosableBaseWindow_WarStatusWindow_WarStatusWindowArgs___ctor__);
		  return;
		}
		*/

		}

		// Token: 0x060042B1 RID: 17073 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60042B1")]
		[Address(RVA = "0x9165", Offset = "0x9165", VA = "0x9165")]
		public WarStatusWindow()
		{
		}

		// Token: 0x040024DA RID: 9434
		[Token(Token = "0x40024DA")]
		public const string WINDOW_ID = "Prefabs/UI/Windows/Clans/Golem/WarStatusWindow";

		// Token: 0x040024DB RID: 9435
		[Token(Token = "0x40024DB")]
		[FieldOffset(Offset = "0x3C")]
		[SerializeField]
		private GameAssetViewRawImage _avatar;

		// Token: 0x040024DC RID: 9436
		[Token(Token = "0x40024DC")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		private TitleWithLevel _titleGroup;

		// Token: 0x040024DD RID: 9437
		[Token(Token = "0x40024DD")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		private TruceStatusView _truceStatusView;

		// Token: 0x040024DE RID: 9438
		[Token(Token = "0x40024DE")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		private WarStatusView _warStatusView;

		// Token: 0x040024DF RID: 9439
		[Token(Token = "0x40024DF")]
		[FieldOffset(Offset = "0x4C")]
		private WarStatusViewMasterMediator _mediator;

		// Token: 0x02000AD1 RID: 2769
		[Token(Token = "0x2000AD1")]
		public class WarStatusWindowArgs : BaseWindowArgs
		{
			// Token: 0x060042B2 RID: 17074 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x60042B2")]
			[Address(RVA = "0x9166", Offset = "0x9166", VA = "0x9166")]
			public WarStatusWindowArgs()
			{
			}

			// Token: 0x040024E0 RID: 9440
			[Token(Token = "0x40024E0")]
			[FieldOffset(Offset = "0x18")]
			public string AprAssetId;

			// Token: 0x040024E1 RID: 9441
			[Token(Token = "0x40024E1")]
			[FieldOffset(Offset = "0x1C")]
			public WarStatusViewMasterMediator Mediator;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_WarStatusView ---
		void Gameplay_Clans_Buildings_Golem_View_WarStatusWindow__get_WarStatusView
		               (int param1,int param2,undefined4 param3)
		
		{
		  int *piVar1;
		  
		  if (DAT_ram_00a57852 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UI_Windows_ClosableBaseWindow_WarStatusWindow_WarStatusWindowArgs__OnShow__);
		    DAT_ram_00a57852 = '\x01';
		  }
		  func_ii_7769(param1,param2,
		               Method_UI_Windows_ClosableBaseWindow_WarStatusWindow_WarStatusWindowArgs__OnShow__);
		  Core_Extensions_Dict_AprDicExt__Get1024AssetId
		            (*(undefined4 *)(param1 + 0x3c),*(undefined4 *)(param2 + 0x18),0);
		  piVar1 = *(int **)(param2 + 0x1c);
		  *(int **)(param1 + 0x4c) = piVar1;
		  (**(code **)((ulonglong)*(uint *)(*piVar1 + 0x160) * 4))
		            (piVar1,param1,*(undefined4 *)(*piVar1 + 0x164));
		  return;
		}
		*/

}
