using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using DefaultNamespace;
using Gameplay.ResourceBar.Control;
using Gameplay.ResourceBar.Events;
using Gameplay.ResourceBar.Model;
using Gameplay.UserInterface.View;
using Il2CppDummyDll;
using Protocol.Consts;
using UI.UIController;
using UnityEngine;

namespace Gameplay.ResourceBar.View
{
	// Token: 0x02000552 RID: 1362
	[Token(Token = "0x2000552")]
	[RequireComponent(typeof(ShowHideUIElementByRestrictions))]
	public class ResourceBarView : MonoBehaviour
	{
		// Token: 0x170005FD RID: 1533
		// (get) Token: 0x060020BF RID: 8383 RVA: 0x000069A8 File Offset: 0x00004BA8
		[Token(Token = "0x170005FD")]
		public ResourceBarColor DefaultColor
		{
			[Token(Token = "0x60020BF")]
			[Address(RVA = "0x7222", Offset = "0x7222", VA = "0x7222")]
			get
			{
				return ResourceBarColor.Default;
			}
		}

		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x060020C0 RID: 8384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005FE")]
		public ShowHideUIElementByRestrictions UIElementByRestrictions
		{
			[Token(Token = "0x60020C0")]
			[Address(RVA = "0x7223", Offset = "0x7223", VA = "0x7223")]
			get
			{
				return null;
			}
		}

		// Token: 0x170005FF RID: 1535
		// (get) Token: 0x060020C1 RID: 8385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170005FF")]
		public Dictionary<Protocol.Consts.Resources, ResourceBarItemView> ItemsDictionary
		{
			[Token(Token = "0x60020C1")]
			[Address(RVA = "0x7224", Offset = "0x7224", VA = "0x7224")]
			get
			{
				return null;
			}
		}

		// Token: 0x1400013E RID: 318
		// (add) Token: 0x060020C2 RID: 8386 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060020C3 RID: 8387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013E")]
		public event Action<Protocol.Consts.Resources> ClickOnResourceViewEvent
		{
			[Token(Token = "0x60020C2")]
			[Address(RVA = "0x7225", Offset = "0x7225", VA = "0x7225")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60020C3")]
			[Address(RVA = "0x7226", Offset = "0x7226", VA = "0x7226")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x1400013F RID: 319
		// (add) Token: 0x060020C4 RID: 8388 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x060020C5 RID: 8389 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400013F")]
		public event Action<bool> GameObjectIsEnableChangedEvent
		{
			[Token(Token = "0x60020C4")]
			[Address(RVA = "0x7227", Offset = "0x7227", VA = "0x7227")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x60020C5")]
			[Address(RVA = "0x7228", Offset = "0x7228", VA = "0x7228")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000600 RID: 1536
		// (get) Token: 0x060020C6 RID: 8390 RVA: 0x000069C0 File Offset: 0x00004BC0
		// (set) Token: 0x060020C7 RID: 8391 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000600")]
		public bool IsInteractive
		{
			[Token(Token = "0x60020C6")]
			[Address(RVA = "0x7229", Offset = "0x7229", VA = "0x7229")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60020C7")]
			[Address(RVA = "0x722A", Offset = "0x722A", VA = "0x722A")]
			set
			{
			}
		}

		// Token: 0x060020C8 RID: 8392 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C8")]
		[Address(RVA = "0x722B", Offset = "0x722B", VA = "0x722B")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_ResourceBar_View_ResourceBarView__OnDestroy(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int param3;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5833b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__set_Item__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_ResourceBar_View_ResourceBarView_OnClickEvent__);
		    DAT_ram_00a5833b = '\x01';
		  }
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      param3 = *(int *)(iVar3 + iVar4 * 4 + 0x10);
		      System_Collections_Generic_Dictionary_Int32Enum__object___ContainsKey
		                (*(undefined4 *)(param1 + 0x24),*(undefined4 *)(param3 + 0x24),param3,
		                 Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__set_Item__
		                );
		      param1_01 = unnamed_function_1417(System_Action_Resources__TypeInfo);
		      System_Action_int___Invoke
		                (param1_01,param1,Method_Gameplay_ResourceBar_View_ResourceBarView_OnClickEvent__,0)
		      ;
		      if (DAT_ram_00a58326 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		        DAT_ram_00a58326 = '\x01';
		      }
		      param1_00 = *(int *)(param3 + 0x30);
		      do {
		        iVar2 = 0;
		        param1_02 = UnityEngine_UI_Image__set_sprite(param1_00,param1_01,0);
		        param2_00 = System_Action_Resources__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_Resources__TypeInfo), iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(param3 + 0x30,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020C9 RID: 8393 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020C9")]
		[Address(RVA = "0x722C", Offset = "0x722C", VA = "0x722C")]
		private void Awake()
		{
		/* --- GHIDRA: Awake ---
		void Gameplay_ResourceBar_View_ResourceBarView__Awake(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  Gameplay_ResourceBar_View_ResourceBarView__DestroyMVC(param1,param1);
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),1,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020CA RID: 8394 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CA")]
		[Address(RVA = "0x722D", Offset = "0x722D", VA = "0x722D")]
		private void OnEnable()
		{
		/* --- GHIDRA: OnEnable ---
		void Gameplay_ResourceBar_View_ResourceBarView__OnEnable(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),0,*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x060020CB RID: 8395 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CB")]
		[Address(RVA = "0x722E", Offset = "0x722E", VA = "0x722E")]
		private void OnDisable()
		{
		}

		// Token: 0x060020CC RID: 8396 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CC")]
		[Address(RVA = "0x722F", Offset = "0x722F", VA = "0x722F")]
		private void OnClickEvent(Protocol.Consts.Resources resourceId)
		{
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CD")]
		[Address(RVA = "0x7230", Offset = "0x7230", VA = "0x7230")]
		private void DestroyMVC()
		{
		/* --- GHIDRA: DestroyMVC ---
		uint Gameplay_ResourceBar_View_ResourceBarView__DestroyMVC(int param1,undefined4 param2)
		
		{
		  char cVar1;
		  uint uVar2;
		  undefined4 uVar3;
		  uint *puVar4;
		  undefined4 uVar5;
		  undefined4 uVar6;
		  undefined4 uVar7;
		  int *param1_00;
		  int iVar8;
		  int *piVar9;
		  
		  if (DAT_ram_00a5833c == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Application_IApp_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ResourceBar_Control_ResourceBarController_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ResourceBar_Events_ResourceBarEvents_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ResourceBar_Model_ResourceBarModel_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_ResourceBar_Control_ResourceBarViewMediator_TypeInfo);
		    DAT_ram_00a5833c = '\x01';
		  }
		  cVar1 = *(char *)(param1 + 0x40);
		  if (cVar1 == '\0') {
		    uVar3 = unnamed_function_1417(Gameplay_ResourceBar_Events_ResourceBarEvents_TypeInfo);
		    *(undefined4 *)(param1 + 0x30) = uVar3;
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *param1_00;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x160);
		          goto code_r0x80ed2b97;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x14);
		code_r0x80ed2b97:
		    uVar3 = (**(code **)((ulonglong)*puVar4 * 4))(param1_00,puVar4[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar9;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x178);
		          goto code_r0x80ed2c43;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x80ed2c43:
		    uVar5 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar9;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0xe0);
		          goto code_r0x80ed2cef;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x80ed2cef:
		    piVar9 = (int *)(**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    uVar2 = 0;
		    iVar8 = *piVar9;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      do {
		        if (Core_Application_IApp_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0xe8);
		          goto code_r0x80ed2d71;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Core_Application_IApp_TypeInfo,5);
		code_r0x80ed2d71:
		    uVar6 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    piVar9 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar8 = *piVar9;
		    if (*(ushort *)(iVar8 + 0xb6) != 0) {
		      uVar2 = 0;
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8)) {
		          puVar4 = (uint *)(*(int *)(*(int *)(iVar8 + 0x58) + uVar2 * 8 + 4) * 8 + iVar8 + 0x140);
		          goto code_r0x80ed2e19;
		        }
		        uVar2 = uVar2 + 1;
		      } while (*(ushort *)(iVar8 + 0xb6) != uVar2);
		    }
		    puVar4 = (uint *)func_ii_1080(piVar9,Core_Gameplay_IGame_TypeInfo,0x10);
		code_r0x80ed2e19:
		    uVar7 = (**(code **)((ulonglong)*puVar4 * 4))(piVar9,puVar4[1]);
		    uVar7 = func_ii_7112(uVar7,0);
		    iVar8 = unnamed_function_1417(Gameplay_ResourceBar_Model_ResourceBarModel_TypeInfo);
		    Unity_Services_Core_Environments_Internal_Environments__get_Current(iVar8,uVar7,0);
		    *(undefined4 *)(iVar8 + 0x14) = uVar6;
		    *(undefined4 *)(iVar8 + 0x10) = uVar5;
		    *(undefined4 *)(iVar8 + 0xc) = uVar3;
		    *(int **)(iVar8 + 0x18) = param1_00;
		    *(int *)(param1 + 0x34) = iVar8;
		    uVar5 = *(undefined4 *)(param1 + 0x30);
		    uVar3 = unnamed_function_1417(Gameplay_ResourceBar_Control_ResourceBarController_TypeInfo);
		    if (DAT_ram_00a58340 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_MVC_AbstractController_ResourceBarModel__ResourceBarEvents___ctor__);
		      DAT_ram_00a58340 = '\x01';
		    }
		    Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		              (uVar3,iVar8,uVar5,
		               Method_MVC_AbstractController_ResourceBarModel__ResourceBarEvents___ctor__);
		    *(undefined4 *)(param1 + 0x38) = uVar3;
		    uVar6 = *(undefined4 *)(param1 + 0x34);
		    uVar7 = *(undefined4 *)(param1 + 0x30);
		    uVar5 = unnamed_function_1417(Gameplay_ResourceBar_Control_ResourceBarViewMediator_TypeInfo);
		    if (DAT_ram_00a58343 == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&
		                 Method_MVC_AbstractCozyViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView___ctor__
		                );
		      DAT_ram_00a58343 = '\x01';
		    }
		    MVC_AbstractController_object__object___set_Model
		              (uVar5,uVar6,uVar7,uVar3,
		               Method_MVC_AbstractCozyViewMediator_ResourceBarModel__ResourceBarEvents__ResourceBarController__ResourceBarView___ctor__
		              );
		    *(undefined4 *)(param1 + 0x3c) = uVar5;
		    MVC_AbstractController__Dispose(*(undefined4 *)(param1 + 0x38),0);
		    iVar8 = **(int **)(param1 + 0x3c);
		    (**(code **)((ulonglong)*(uint *)(iVar8 + 0x160) * 4))
		              (*(int **)(param1 + 0x3c),param1,*(undefined4 *)(iVar8 + 0x164));
		    *(undefined1 *)(param1 + 0x40) = 1;
		  }
		  return (uint)(cVar1 == '\0');
		}
		*/

		}

		// Token: 0x060020CE RID: 8398 RVA: 0x000069D8 File Offset: 0x00004BD8
		[Token(Token = "0x60020CE")]
		[Address(RVA = "0x7231", Offset = "0x7231", VA = "0x7231")]
		private bool TrySetupMVC()
		{
		/* --- GHIDRA: TrySetupMVC ---
		void Gameplay_ResourceBar_View_ResourceBarView__TrySetupMVC(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x38),0);
		  iVar1 = **(int **)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0xe8) * 4))
		            (*(int **)(param1 + 0x34),*(undefined4 *)(iVar1 + 0xec));
		  iVar1 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar1 + 0x130) * 4))
		            (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar1 + 0x134));
		  *(undefined1 *)(param1 + 0x40) = 0;
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020CF")]
		[Address(RVA = "0x7232", Offset = "0x7232", VA = "0x7232")]
		public void ResetInitialize()
		{
		/* --- GHIDRA: ResetInitialize ---
		undefined4
		Gameplay_ResourceBar_View_ResourceBarView__ResetInitialize
		          (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5833d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__TryGetValue__
		              );
		    DAT_ram_00a5833d = '\x01';
		  }
		  uVar1 = System_Collections_Generic_List_Enumerator_ValueTuple_object__double____MoveNext
		                    (*(undefined4 *)(param1 + 0x24),param2,param3,
		                     Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__TryGetValue__
		                    );
		  return uVar1;
		}
		*/

		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x000069F0 File Offset: 0x00004BF0
		[Token(Token = "0x60020D0")]
		[Address(RVA = "0x7233", Offset = "0x7233", VA = "0x7233")]
		public bool TryGetResourceBarItemView(Protocol.Consts.Resources resource, out ResourceBarItemView view)
		{
		/* --- GHIDRA: TryGetResourceBarItemView ---
		void Gameplay_ResourceBar_View_ResourceBarView__TryGetResourceBarItemView
		               (int param1,undefined4 *param2,undefined4 param3)
		
		{
		  undefined1 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  int iVar6;
		  undefined8 uVar7;
		  undefined8 local_20;
		  undefined8 local_18;
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  iVar6 = 0;
		  iVar2 = UI_UserContextMenu_ContextElements_VisitIsleUserContextMenuElement___ctor
		                    (*(undefined4 *)(param1 + 0x14),*param2,0);
		  iVar3 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      iVar4 = *(int *)(*(int *)(iVar3 + iVar6 * 4 + 0x10) + 0x10);
		      local_18 = *(undefined8 *)(iVar2 + 0x14);
		      local_20 = *(undefined8 *)(iVar2 + 0xc);
		      uVar1 = *(undefined1 *)(iVar2 + 0x1c);
		      uVar7 = *(undefined8 *)(iVar2 + 0xc);
		      *(undefined8 *)(iVar4 + 0x20) = *(undefined8 *)(iVar2 + 0x14);
		      *(undefined8 *)(iVar4 + 0x18) = uVar7;
		      iVar5 = **(int **)(iVar4 + 0x14);
		      local_10 = local_20;
		      local_8 = local_18;
		      (**(code **)((ulonglong)*(uint *)(iVar5 + 0x178) * 4))
		                (*(int **)(iVar4 + 0x14),&local_20,*(undefined4 *)(iVar5 + 0x17c));
		      *(undefined1 *)(iVar4 + 0x2c) = uVar1;
		      iVar6 = iVar6 + 1;
		    } while (iVar6 < *(int *)(iVar3 + 0xc));
		  }
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D1")]
		[Address(RVA = "0x7234", Offset = "0x7234", VA = "0x7234")]
		public void SetColor(in ResourceBarColor resourceBarColor)
		{
		/* --- GHIDRA: SetColor ---
		uint Gameplay_ResourceBar_View_ResourceBarView__SetColor
		               (int param1,int *param2,uint param3,undefined4 param4)
		
		{
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  uint uVar4;
		  
		  if (DAT_ram_00a5833e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_ICollection_Scenes__TypeInfo);
		    DAT_ram_00a5833e = '\x01';
		  }
		  uVar2 = *(undefined4 *)(param1 + 0x1c);
		  iVar3 = *param2;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar4 = 0;
		    do {
		      if (System_Collections_Generic_ICollection_Scenes__TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8)) {
		        puVar1 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar4 * 8 + 4) * 8 + iVar3 + 0xe0);
		        goto code_r0x80ed319a;
		      }
		      uVar4 = uVar4 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar4);
		  }
		  puVar1 = (uint *)func_ii_1080(param2,System_Collections_Generic_ICollection_Scenes__TypeInfo,4);
		code_r0x80ed319a:
		  iVar3 = (**(code **)((ulonglong)*puVar1 * 4))(param2,uVar2,puVar1[1]);
		  if (iVar3 == 0) {
		    uVar4 = 0;
		  }
		  else {
		    uVar4 = (uint)(*(char *)(param1 + 0x20) != '\0');
		  }
		  return uVar4 & param3;
		}
		*/

		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x00006A08 File Offset: 0x00004C08
		[Token(Token = "0x60020D2")]
		[Address(RVA = "0x7235", Offset = "0x7235", VA = "0x7235")]
		public bool GetIsActiveState(IList<Scenes> scenes, bool expectedActive)
		{
		/* --- GHIDRA: GetIsActiveState ---
		void Gameplay_ResourceBar_View_ResourceBarView__GetIsActiveState(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5833f == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView___ctor__
		              );
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__TypeInfo);
		    DAT_ram_00a5833f = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (
		                        System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__TypeInfo
		                        );
		  System_Collections_Generic_Dictionary_Int32Enum__Int32Enum___set_Item
		            (param1_00,
		             Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView___ctor__);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x060020D3 RID: 8403 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60020D3")]
		[Address(RVA = "0x7236", Offset = "0x7236", VA = "0x7236")]
		public ResourceBarView()
		{
		}

		// Token: 0x040011E4 RID: 4580
		[Token(Token = "0x40011E4")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private ResourceBarItemView[] _items;

		// Token: 0x040011E5 RID: 4581
		[Token(Token = "0x40011E5")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private ResourceBarColorSO _resourceBarColors;

		// Token: 0x040011E6 RID: 4582
		[Token(Token = "0x40011E6")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private ResourceBarColor _defaultColor;

		// Token: 0x040011E7 RID: 4583
		[Token(Token = "0x40011E7")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private ResourceBarView.ActivStateByScene _activeStateByScene;

		// Token: 0x040011E8 RID: 4584
		[Token(Token = "0x40011E8")]
		[FieldOffset(Offset = "0x24")]
		private readonly Dictionary<Protocol.Consts.Resources, ResourceBarItemView> _itemsDictionary;

		// Token: 0x040011EB RID: 4587
		[Token(Token = "0x40011EB")]
		[FieldOffset(Offset = "0x30")]
		private ResourceBarEvents _events;

		// Token: 0x040011EC RID: 4588
		[Token(Token = "0x40011EC")]
		[FieldOffset(Offset = "0x34")]
		private ResourceBarModel _model;

		// Token: 0x040011ED RID: 4589
		[Token(Token = "0x40011ED")]
		[FieldOffset(Offset = "0x38")]
		private ResourceBarController _controller;

		// Token: 0x040011EE RID: 4590
		[Token(Token = "0x40011EE")]
		[FieldOffset(Offset = "0x3C")]
		private ResourceBarViewMediator _mediator;

		// Token: 0x040011EF RID: 4591
		[Token(Token = "0x40011EF")]
		[FieldOffset(Offset = "0x40")]
		private bool _isInitialized;

		// Token: 0x040011F0 RID: 4592
		[Token(Token = "0x40011F0")]
		[FieldOffset(Offset = "0x41")]
		private bool _isInteractive;

		// Token: 0x02000553 RID: 1363
		[Token(Token = "0x2000553")]
		[Serializable]
		internal struct ActivStateByScene
		{
			// Token: 0x17000601 RID: 1537
			// (get) Token: 0x060020D4 RID: 8404 RVA: 0x00006A20 File Offset: 0x00004C20
			[Token(Token = "0x17000601")]
			public Scenes Scene
			{
				[Token(Token = "0x60020D4")]
				[Address(RVA = "0x7237", Offset = "0x7237", VA = "0x7237")]
				get
				{
					return Scenes.Preloader;
				}
			}

			// Token: 0x17000602 RID: 1538
			// (get) Token: 0x060020D5 RID: 8405 RVA: 0x00006A38 File Offset: 0x00004C38
			[Token(Token = "0x17000602")]
			public bool IsActive
			{
				[Token(Token = "0x60020D5")]
				[Address(RVA = "0x7238", Offset = "0x7238", VA = "0x7238")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x040011F1 RID: 4593
			[Token(Token = "0x40011F1")]
			[FieldOffset(Offset = "0x0")]
			[SerializeField]
			private Scenes _scene;

			// Token: 0x040011F2 RID: 4594
			[Token(Token = "0x40011F2")]
			[FieldOffset(Offset = "0x4")]
			[SerializeField]
			private bool _isActive;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_DefaultColor ---
		undefined4
		Gameplay_ResourceBar_View_ResourceBarView__get_DefaultColor(undefined4 param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58335 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_UnityEngine_Component_GetComponent_ShowHideUIElementByRestrictions___);
		    DAT_ram_00a58335 = '\x01';
		  }
		  uVar1 = func_ii_5677(param1,
		                       Method_UnityEngine_Component_GetComponent_ShowHideUIElementByRestrictions___)
		  ;
		  return uVar1;
		}
		*/


		/* --- GHIDRA: get_ItemsDictionary ---
		void Gameplay_ResourceBar_View_ResourceBarView__get_ItemsDictionary
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58336 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    DAT_ram_00a58336 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_Resources__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Resources__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_ClickOnResourceViewEvent ---
		void Gameplay_ResourceBar_View_ResourceBarView__add_ClickOnResourceViewEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58337 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    DAT_ram_00a58337 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x28);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_Resources__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_Resources__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x28,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_ClickOnResourceViewEvent ---
		void Gameplay_ResourceBar_View_ResourceBarView__remove_ClickOnResourceViewEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58338 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a58338 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: add_GameObjectIsEnableChangedEvent ---
		void Gameplay_ResourceBar_View_ResourceBarView__add_GameObjectIsEnableChangedEvent
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a58339 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_bool__TypeInfo);
		    DAT_ram_00a58339 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x2c);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = func_ii_7048(param1_00,param2,0);
		    param2_00 = System_Action_bool__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_bool__TypeInfo), iVar2 == 0)) break;
		    iVar2 = func_ii_4329(param1 + 0x2c,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: get_IsInteractive ---
		void Gameplay_ResourceBar_View_ResourceBarView__get_IsInteractive
		               (int param1,int param2,undefined4 param3)
		
		{
		  char cVar1;
		  uint uVar2;
		  int iVar3;
		  undefined4 uVar4;
		  int iVar5;
		  uint uVar6;
		  int iVar7;
		  uint uVar8;
		  undefined1 uVar9;
		  uint uVar10;
		  undefined8 local_10;
		  undefined4 local_8;
		  
		  uVar8 = 0;
		  uVar9 = (undefined1)param2;
		  *(undefined1 *)(param1 + 0x41) = uVar9;
		  iVar5 = *(int *)(param1 + 0x10);
		  uVar6 = *(uint *)(iVar5 + 0xc);
		  if (0 < (int)uVar6) {
		    if (param2 == 0) {
		      iVar3 = 0;
		      do {
		        iVar7 = *(int *)(iVar5 + iVar3 * 4 + 0x10);
		        cVar1 = *(char *)(param1 + 0x41);
		        *(char *)(iVar7 + 0x44) = cVar1;
		        if (cVar1 == '\0') {
		          uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x10),0);
		          func_ii_8007(uVar4,0,0);
		          uVar4 = System_Collections_Generic_SortedDictionary_Enumerator_object__object___get_Current
		                            (*(undefined4 *)(*(int *)(iVar7 + 0x10) + 0x10),0);
		          if (DAT_ram_00a6501f == '\0') {
		            Mono_Security_ASN1__get_Item(&UnityEngine_Vector3_TypeInfo);
		            DAT_ram_00a6501f = '\x01';
		          }
		          local_8 = *(undefined4 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0x14);
		          local_10 = *(undefined8 *)(*(int *)(UnityEngine_Vector3_TypeInfo + 0x5c) + 0xc);
		          Com_TheFallenGames_OSA_Core_OSA_object__object___SetNormalizedPosition(uVar4,&local_10,0);
		          uVar6 = *(uint *)(iVar5 + 0xc);
		        }
		        iVar3 = iVar3 + 1;
		      } while (iVar3 < (int)uVar6);
		    }
		    else {
		      uVar2 = 0;
		      iVar3 = 0;
		      if (3 < uVar6) {
		        iVar7 = iVar5 + 0x10;
		        do {
		          uVar10 = iVar3 * 4;
		          *(undefined1 *)(*(int *)(iVar7 + uVar10) + 0x44) = uVar9;
		          *(undefined1 *)(*(int *)(iVar7 + (uVar10 | 4)) + 0x44) = uVar9;
		          *(undefined1 *)(*(int *)(iVar7 + (uVar10 | 8)) + 0x44) = uVar9;
		          *(undefined1 *)(*(int *)(iVar7 + (uVar10 | 0xc)) + 0x44) = uVar9;
		          iVar3 = iVar3 + 4;
		          uVar8 = uVar8 + 4;
		        } while (uVar8 != (uVar6 & 0xfffffffc));
		      }
		      if ((uVar6 & 3) != 0) {
		        do {
		          *(undefined1 *)(*(int *)(iVar5 + iVar3 * 4 + 0x10) + 0x44) = uVar9;
		          iVar3 = iVar3 + 1;
		          uVar2 = uVar2 + 1;
		        } while (uVar2 != (uVar6 & 3));
		      }
		    }
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_IsInteractive ---
		void Gameplay_ResourceBar_View_ResourceBarView__set_IsInteractive(int param1,undefined4 param2)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  undefined4 param1_01;
		  int param1_02;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a5833a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__Clear__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_ResourceBar_View_ResourceBarView_OnClickEvent__);
		    DAT_ram_00a5833a = '\x01';
		  }
		  MVC_AbstractController__Run(*(undefined4 *)(param1 + 0x38),0);
		  iVar5 = **(int **)(param1 + 0x34);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe8) * 4))
		            (*(int **)(param1 + 0x34),*(undefined4 *)(iVar5 + 0xec));
		  iVar5 = **(int **)(param1 + 0x3c);
		  (**(code **)((ulonglong)*(uint *)(iVar5 + 0x130) * 4))
		            (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar5 + 0x134));
		  *(undefined1 *)(param1 + 0x40) = 0;
		  iVar5 = *(int *)(param1 + 0x10);
		  if (0 < *(int *)(iVar5 + 0xc)) {
		    do {
		      iVar3 = *(int *)(iVar5 + iVar4 * 4 + 0x10);
		      param1_01 = unnamed_function_1417(System_Action_Resources__TypeInfo);
		      System_Action_int___Invoke
		                (param1_01,param1,Method_Gameplay_ResourceBar_View_ResourceBarView_OnClickEvent__,0)
		      ;
		      if (DAT_ram_00a58327 == '\0') {
		        Mono_Security_ASN1__get_Item(&System_Action_Resources__TypeInfo);
		        DAT_ram_00a58327 = '\x01';
		      }
		      param1_00 = *(int *)(iVar3 + 0x30);
		      do {
		        iVar2 = 0;
		        param1_02 = func_ii_7048(param1_00,param1_01,0);
		        param2_00 = System_Action_Resources__TypeInfo;
		        if ((param1_02 != 0) &&
		           (iVar2 = func_ii_1082(param1_02,System_Action_Resources__TypeInfo), iVar2 == 0)) {
		          System_Activator__CreateInstance(param1_02,param2_00);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        iVar2 = func_ii_4329(iVar3 + 0x30,iVar2,param1_00);
		        bVar1 = iVar2 != param1_00;
		        param1_00 = iVar2;
		      } while (bVar1);
		      iVar4 = iVar4 + 1;
		    } while (iVar4 < *(int *)(iVar5 + 0xc));
		  }
		  System_Xml_XmlWellFormedWriter__PushNamespaceImplicit
		            (*(undefined4 *)(param1 + 0x24),
		             Method_System_Collections_Generic_Dictionary_Resources__ResourceBarItemView__Clear__);
		  return;
		}
		*/

}
