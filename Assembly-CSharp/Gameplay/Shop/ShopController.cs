using System;
using System.Runtime.CompilerServices;
using Core.Data;
using Google.Protobuf;
using Il2CppDummyDll;
using MVC;
using Protocol.Shop;
using ServicesNamespace;
using Utils;

namespace Gameplay.Shop
{
	// Token: 0x02000542 RID: 1346
	[Token(Token = "0x2000542")]
	public class ShopController : AbstractController<ShopModel, ShopEvents>
	{
		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002048 RID: 8264 RVA: 0x000067E0 File Offset: 0x000049E0
		// (set) Token: 0x06002049 RID: 8265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170005E6")]
		public bool ItemsRequested
		{
			[Token(Token = "0x6002048")]
			[Address(RVA = "0x71AD", Offset = "0x71AD", VA = "0x71AD")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6002049")]
			[Address(RVA = "0x71AE", Offset = "0x71AE", VA = "0x71AE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600204A RID: 8266 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204A")]
		[Address(RVA = "0x71AF", Offset = "0x71AF", VA = "0x71AF")]
		public ShopController(ShopModel model, ShopEvents events)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Competition_Control_Sections_ShopController___ctor(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  undefined4 *puVar4;
		  undefined4 uVar5;
		  undefined4 param2_00;
		  int iVar6;
		  int *piVar7;
		  uint *puVar8;
		  int iVar9;
		  int *piVar10;
		  int local_10;
		  int **local_c;
		  undefined4 local_8;
		  int *local_4;
		  
		  if (DAT_ram_00a63b0b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_IDisposable_TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_IEnumerator_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_IEnumerator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_BankOptionData___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_BankOptionData__TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__);
		    DAT_ram_00a63b0b = '\x01';
		  }
		  local_8 = 0;
		  iVar2 = unnamed_function_1417(System_Collections_Generic_List_BankOptionData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (iVar2,Method_System_Collections_Generic_List_BankOptionData___ctor__);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  local_4 = (int *)Google_Protobuf_Collections_RepeatedField_float___Equals
		                             (*(undefined4 *)
		                               (*(int *)(*(int *)(*(int *)(iVar3 + 0x14) + 0x2c) + 8) + 0x14),
		                              Method_Google_Protobuf_Collections_RepeatedField_uint__GetEnumerator__
		                             );
		  local_10 = 0;
		  local_c = &local_4;
		code_r0x8233e65d:
		  do {
		    do {
		      piVar7 = local_4;
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (System_Collections_IEnumerator_TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar3 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x8233e703;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_IEnumerator_TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8233e747:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233e9bc;
		      }
		code_r0x8233e703:
		      DAT_ram_009d3e38 = 0;
		      iVar3 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      piVar7 = local_4;
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8233e747;
		      if (iVar3 == 0) goto code_r0x8233ea05;
		      iVar3 = *local_4;
		      if (*(ushort *)(iVar3 + 0xb6) != 0) {
		        uVar1 = 0;
		        do {
		          piVar10 = (int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8);
		          if (System_Collections_Generic_IEnumerator_uint__TypeInfo == *piVar10) {
		            puVar4 = (undefined4 *)(iVar3 + piVar10[1] * 8 + 0xc0);
		            goto code_r0x8233e7f4;
		          }
		          uVar1 = uVar1 + 1;
		        } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		      }
		      DAT_ram_009d3e38 = 0;
		      puVar4 = (undefined4 *)
		               import::env::invoke_iiii
		                         (s_Allocator__0___Blocksize__1__mus_ram_00000421 + 0x18,local_4,
		                          System_Collections_Generic_IEnumerator_uint__TypeInfo,0);
		      if (DAT_ram_009d3e38 == 1) {
		code_r0x8233e8fc:
		        DAT_ram_009d3e38 = 0;
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233e9bc;
		      }
		code_r0x8233e7f4:
		      DAT_ram_009d3e38 = 0;
		      uVar5 = import::env::invoke_iii(*puVar4,piVar7,puVar4[1]);
		      if (DAT_ram_009d3e38 == 1) goto code_r0x8233e8fc;
		      DAT_ram_009d3e38 = 0;
		      iVar6 = import::env::invoke_iii
		                        (*(undefined4 *)(*param1 + 0x100),param1,*(undefined4 *)(*param1 + 0x104));
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233e9bc;
		      }
		      iVar3 = **(int **)(iVar6 + 0x10);
		      DAT_ram_009d3e38 = 0;
		      param2_00 = import::env::invoke_iii
		                            (*(undefined4 *)(iVar3 + 0x100),*(int **)(iVar6 + 0x10),
		                             *(undefined4 *)(iVar3 + 0x104));
		      iVar3 = DAT_ram_009d3e38;
		      DAT_ram_009d3e38 = 0;
		      if (iVar3 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233e9bc;
		      }
		      DAT_ram_009d3e38 = 0;
		      iVar9 = import::env::invoke_iiiii
		                        (s_struct_Uniforms___color__array<v_ram_000017c8 + 0x314,param2_00,uVar5,
		                         &local_8,0);
		      iVar6 = DAT_ram_009d3e38;
		      iVar3 = Method_System_Collections_Generic_List_BankOptionData__Add__;
		      DAT_ram_009d3e38 = 0;
		      if (iVar6 == 1) {
		        uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		        goto code_r0x8233e9bc;
		      }
		    } while (iVar9 == 0);
		    *(int *)(iVar2 + 0x10) = *(int *)(iVar2 + 0x10) + 1;
		    uVar1 = *(uint *)(iVar2 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(iVar2 + 8) + 0xc)) {
		      *(uint *)(iVar2 + 0xc) = uVar1 + 1;
		      *(undefined4 *)(*(int *)(iVar2 + 8) + uVar1 * 4 + 0x10) = local_8;
		      goto code_r0x8233e65d;
		    }
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_viii
		              (s_struct_Uniforms___color__array<v_ram_00000aff + 0x6e,iVar2,local_8,
		               *(undefined4 *)(*(int *)(*(int *)(iVar3 + 0x10) + 0x60) + 0x38));
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		  } while (iVar3 != 1);
		  uVar5 = import::env::__cxa_find_matching_catch_3(&DAT_ram_0072c9c8);
		code_r0x8233e9bc:
		  iVar3 = global_1;
		  iVar6 = import::env::llvm_eh_typeid_for(&DAT_ram_0072c9c8);
		  if (iVar3 == iVar6) {
		    piVar7 = (int *)import::env::__cxa_begin_catch(uVar5);
		    local_10 = *piVar7;
		    DAT_ram_009d3e38 = 0;
		    import::env::invoke_v(0x123);
		    iVar3 = DAT_ram_009d3e38;
		    DAT_ram_009d3e38 = 0;
		    if (iVar3 != 1) {
		code_r0x8233ea05:
		      DAT_ram_009d3e38 = 0;
		      piVar7 = *local_c;
		      if (piVar7 != (int *)0x0) {
		        uVar1 = 0;
		        iVar3 = *piVar7;
		        if (*(ushort *)(iVar3 + 0xb6) != 0) {
		          do {
		            if (System_IDisposable_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		              puVar8 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0)
		              ;
		              goto code_r0x8233ea80;
		            }
		            uVar1 = uVar1 + 1;
		          } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		        }
		        puVar8 = (uint *)func_ii_1080(piVar7,System_IDisposable_TypeInfo,0);
		code_r0x8233ea80:
		        (**(code **)((ulonglong)*puVar8 * 4))(piVar7,puVar8[1]);
		      }
		      if (local_10 == 0) {
		        iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		        if (DAT_ram_00a63aca == '\0') {
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BankOptionData__AddRange__);
		          Mono_Security_ASN1__get_Item
		                    (&Method_System_Collections_Generic_List_BankOptionData__Clear__);
		          DAT_ram_00a63aca = '\x01';
		        }
		        iVar9 = *(int *)(iVar3 + 0xc);
		        iVar6 = *(int *)(iVar9 + 0xc);
		        *(undefined4 *)(iVar9 + 0xc) = 0;
		        *(int *)(iVar9 + 0x10) = *(int *)(iVar9 + 0x10) + 1;
		        if (0 < iVar6) {
		          func_ii_2064(*(undefined4 *)(iVar9 + 8),0,iVar6,0);
		          iVar9 = *(int *)(iVar3 + 0xc);
		        }
		        func_ii_6335(iVar9,iVar2,Method_System_Collections_Generic_List_BankOptionData__AddRange__);
		        *(undefined1 *)((int)param1 + 9) = 1;
		        iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x114));
		        iVar2 = *(int *)(iVar2 + 8);
		        if (iVar2 != 0) {
		          (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                    (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		        }
		        return;
		      }
		      System_Data_DataSet__ValidateLocaleConstraint(local_10);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    uVar5 = import::env::__cxa_find_matching_catch_2();
		  }
		  DAT_ram_009d3e38 = 0;
		  import::env::invoke_ii(s___Scripting__Unity__IO__Archive__ram_00004472 + 0x31,&local_10);
		  iVar2 = DAT_ram_009d3e38;
		  DAT_ram_009d3e38 = 0;
		  if (iVar2 == 1) {
		    import::env::__cxa_find_matching_catch_3(0);
		    unnamed_function_937();
		    do {
		      halt_trap();
		    } while( true );
		  }
		  import::env::__resumeException(uVar5);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		/* --- GHIDRA: .ctor ---
		void Gameplay_Shop_ShopController___ctor(int *param1,undefined4 param2)
		
		{
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58304 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactMovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactBuyedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopController_BuildingStateChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopController_OnArtifactBuyed__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopController_OnArtifactMoved__);
		    DAT_ram_00a58304 = '\x01';
		  }
		  *(undefined1 *)((int)param1 + 9) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 8);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  iVar1 = param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoArtifactBuyedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Shop_ShopController_OnArtifactBuyed__,0);
		  ServicesNamespace_ShopService__get_ServiceId(iVar1,uVar2,0);
		  iVar1 = param1[6];
		  uVar2 = unnamed_function_1417(System_Action_ProtoArtifactMovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar2,param1,Method_Gameplay_Shop_ShopController_OnArtifactMoved__,0);
		  ServicesNamespace_ShopService__remove_ArtifactBuyedEvent(iVar1,uVar2,0);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(*(int *)(iVar1 + 0x14) + 0xc);
		  param1_00 = *(undefined4 *)(iVar4 + 0x14);
		  uVar2 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar2,param1,Method_Gameplay_Shop_ShopController_BuildingStateChangedEvent__,0);
		  iVar1 = UnityEngine_UI_Image__set_sprite(param1_00,uVar2,0);
		  uVar2 = System_Action_uint__TypeInfo;
		  if (iVar1 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		    Gameplay_Shop_ShopController__OnArtifactMoved(param1,param1);
		    return;
		  }
		  iVar3 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		  if (iVar3 == 0) {
		    System_Activator__CreateInstance(iVar1,uVar2);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  *(int *)(iVar4 + 0x14) = iVar3;
		  uVar2 = System_Action_uint__TypeInfo;
		  iVar4 = func_ii_1082(iVar1,System_Action_uint__TypeInfo);
		  if (iVar4 != 0) {
		    Gameplay_Shop_ShopController__OnArtifactMoved(param1,param1);
		    return;
		  }
		  System_Activator__CreateInstance(iVar1,uVar2);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204B")]
		[Address(RVA = "0x71B0", Offset = "0x71B0", VA = "0x71B0", Slot = "7")]
		protected override void HandleRun()
		{
		/* --- GHIDRA: HandleRun ---
		void Gameplay_Competition_Control_Sections_ShopController__HandleRun
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Bank_Controller_BankController__RequestActivePromotions
		            (*(undefined4 *)(iVar1 + 0x10),param2,0);
		  return;
		}
		*/

		/* --- GHIDRA: HandleRun ---
		void Gameplay_Shop_ShopController__HandleRun(int *param1,undefined4 param2)
		
		{
		  undefined4 uVar1;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a58305 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Isles_Base_AbstractIsle_UserIsleEvents__UserIsleModel__UserIsleController__UserBuildingTypes__get_Events__
		              );
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactMovedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_ProtoArtifactBuyedEvt__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Action_uint__TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopController_BuildingStateChangedEvent__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopController_OnArtifactBuyed__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopController_OnArtifactMoved__);
		    DAT_ram_00a58305 = '\x01';
		  }
		  iVar3 = param1[6];
		  uVar1 = unnamed_function_1417(System_Action_ProtoArtifactBuyedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Shop_ShopController_OnArtifactBuyed__,0);
		  ServicesNamespace_ShopService__add_ArtifactBuyedEvent(iVar3,uVar1,0);
		  iVar3 = param1[6];
		  uVar1 = unnamed_function_1417(System_Action_ProtoArtifactMovedEvt__TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar1,param1,Method_Gameplay_Shop_ShopController_OnArtifactMoved__,0);
		  ServicesNamespace_ShopService__add_ArtifactMovedEvent(iVar3,uVar1,0);
		  iVar3 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  iVar4 = *(int *)(*(int *)(iVar3 + 0x14) + 0xc);
		  param1_00 = *(undefined4 *)(iVar4 + 0x14);
		  uVar1 = unnamed_function_1417(System_Action_uint__TypeInfo);
		  func_ii_12322(uVar1,param1,Method_Gameplay_Shop_ShopController_BuildingStateChangedEvent__,0);
		  iVar3 = func_ii_7048(param1_00,uVar1,0);
		  uVar1 = System_Action_uint__TypeInfo;
		  if (iVar3 == 0) {
		    *(undefined4 *)(iVar4 + 0x14) = 0;
		  }
		  else {
		    iVar2 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar2 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    *(int *)(iVar4 + 0x14) = iVar2;
		    uVar1 = System_Action_uint__TypeInfo;
		    iVar4 = func_ii_1082(iVar3,System_Action_uint__TypeInfo);
		    if (iVar4 == 0) {
		      System_Activator__CreateInstance(iVar3,uVar1);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  *(undefined1 *)(param1 + 7) = 0;
		  return;
		}
		*/

		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204C")]
		[Address(RVA = "0x71B1", Offset = "0x71B1", VA = "0x71B1", Slot = "6")]
		protected override void HandleStop()
		{
		/* --- GHIDRA: HandleStop ---
		void Gameplay_Shop_ShopController__HandleStop(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  
		  if (param2 == 3) {
		    param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                          (param1,*(undefined4 *)(*param1 + 0x104));
		    Gameplay_Shop_ShopModel___ctor(param1_00,param1);
		    Gameplay_Shop_ShopController__OnArtifactMoved(param1,param1);
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600204D RID: 8269 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204D")]
		[Address(RVA = "0x71B2", Offset = "0x71B2", VA = "0x71B2")]
		private void BuildingStateChangedEvent(uint building)
		{
		/* --- GHIDRA: BuildingStateChangedEvent ---
		void Gameplay_Shop_ShopController__BuildingStateChangedEvent
		               (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 in_register_20000014;
		  undefined4 param1_00;
		  int iVar1;
		  
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  Gameplay_Shop_ShopModel__UpdateShopLevel(param1_00,*(undefined8 *)(param2 + 0x18),param1);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600204E RID: 8270 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204E")]
		[Address(RVA = "0x71B3", Offset = "0x71B3", VA = "0x71B3")]
		private void OnArtifactBuyed(ProtoArtifactBuyedEvt evt)
		{
		/* --- GHIDRA: OnArtifactBuyed ---
		void Gameplay_Shop_ShopController__OnArtifactBuyed(int *param1,int param2,undefined4 param3)
		
		{
		  int iVar1;
		  undefined4 param3_00;
		  longlong lVar2;
		  int iVar3;
		  int iVar4;
		  longlong lVar5;
		  uint uVar6;
		  
		  param3_00 = 0;
		  lVar5 = *(longlong *)(param2 + 0x10);
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x104));
		  lVar2 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                    (*(undefined4 *)(iVar1 + 8),0);
		  if (lVar5 == lVar2) {
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x104));
		    iVar3 = *(int *)(param2 + 0x18);
		    if (DAT_ram_00a5831f == '\0') {
		      Mono_Security_ASN1__get_Item
		                (&Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		      DAT_ram_00a5831f = '\x01';
		    }
		    iVar4 = *(int *)(iVar3 + 0xc);
		    if (*(int *)(iVar4 + 0x10) != 0) {
		      param3_00 = Gameplay_Shop_ShopModel__UpdateItems(iVar1,iVar3,param1);
		      iVar4 = *(int *)(iVar3 + 0xc);
		    }
		    iVar3 = *(int *)(iVar4 + 0xc);
		    uVar6 = *(uint *)(*(int *)(iVar1 + 0x18) + 0x10);
		    if ((longlong)(ulonglong)uVar6 < (longlong)iVar3) {
		      iVar3 = *(int *)(iVar1 + 0x24) + iVar3 + (uVar6 ^ 0xffffffff);
		    }
		    else {
		      iVar3 = iVar3 + -1;
		    }
		    System_Collections_Generic_List_UsageHint___get_Item
		              (*(undefined4 *)(iVar1 + 0x2c),iVar3,param3_00,
		               Method_System_Collections_Generic_List_ShopArtifactDataDecorator__set_Item__);
		    iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar1 = *(int *)(iVar1 + 0x14);
		    if (iVar1 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		                (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x0600204F RID: 8271 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600204F")]
		[Address(RVA = "0x71B4", Offset = "0x71B4", VA = "0x71B4")]
		private void OnArtifactMoved(ProtoArtifactMovedEvt evt)
		{
		/* --- GHIDRA: OnArtifactMoved ---
		void Gameplay_Shop_ShopController__OnArtifactMoved(int *param1,undefined4 param2)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  undefined4 uVar2;
		  undefined4 param1_00;
		  undefined8 param2_00;
		  int param1_01;
		  
		  if (DAT_ram_00a58306 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Shop_ShopController_RequestShopItemsResultHandler__);
		    DAT_ram_00a58306 = '\x01';
		  }
		  param1_01 = param1[6];
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104)));
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(iVar1 + 8),0);
		  uVar2 = ServicesNamespace_ShopService__ServerEventHandler(param1_01,param2_00,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Shop_ShopController_RequestShopItemsResultHandler__,0)
		  ;
		  uVar2 = ServicesNamespace_MainService__GetUserStats
		                    (uVar2,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar2,0);
		  return;
		}
		*/

		}

		// Token: 0x06002050 RID: 8272 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002050")]
		[Address(RVA = "0x71B5", Offset = "0x71B5", VA = "0x71B5")]
		public void RequestShopItems()
		{
		/* --- GHIDRA: RequestShopItems ---
		void Gameplay_Shop_ShopController__RequestShopItems(int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 param1_00;
		  int iVar1;
		  int *param1_01;
		  
		  if (DAT_ram_00a58307 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoGetShopItemsInfoAns_TypeInfo);
		    DAT_ram_00a58307 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_01 = *(int **)(param2 + 0x20);
		  if ((param1_01 != (int *)0x0) && (Protocol_Shop_ProtoGetShopItemsInfoAns_TypeInfo != *param1_01))
		  {
		    System_Activator__CreateInstance(param1_01,Protocol_Shop_ProtoGetShopItemsInfoAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0x104));
		  Gameplay_Shop_ShopModel__ToServerId(param1_00,param1_01,param1);
		  *(undefined1 *)(param1 + 7) = 1;
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x114));
		  iVar1 = *(int *)(iVar1 + 0x14);
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002051 RID: 8273 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002051")]
		[Address(RVA = "0x71B6", Offset = "0x71B6", VA = "0x71B6")]
		private void RequestShopItemsResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: RequestShopItemsResultHandler ---
		void Gameplay_Shop_ShopController__RequestShopItemsResultHandler
		               (int *param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  undefined4 in_register_20000014;
		  int iVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  undefined8 uVar5;
		  int param1_00;
		  
		  if (DAT_ram_00a58308 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Gameplay_Shop_ShopController_OnItemsMovedToShop__);
		    Mono_Security_ASN1__get_Item(&StringLiteral_10799);
		    DAT_ram_00a58308 = '\x01';
		  }
		  uVar5 = CONCAT44(in_register_20000014,*(undefined4 *)(*param1 + 0x104));
		  iVar1 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		  uVar3 = (undefined4)((ulonglong)uVar5 >> 0x20);
		  iVar1 = *(int *)(iVar1 + 0x28);
		  if (iVar1 == -1) {
		    uVar5 = CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104));
		    uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))(param1,uVar5);
		    uVar3 = (undefined4)((ulonglong)uVar5 >> 0x20);
		    if (param3 == 0) {
		      iVar1 = Gameplay_Shop_ShopModel__RemoveArtifactById(uVar4,param1);
		    }
		    else {
		      iVar1 = Gameplay_Shop_ShopModel__GetFirstNormalEmptySlot(uVar4,param1);
		    }
		    if (iVar1 == -1) {
		      uVar3 = System_Uri___ctor(0);
		      uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		      if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		        func_ii_306000(Core_GameLocalization_TypeInfo);
		      }
		      uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_10799,1,0,1,0,0,0,0);
		      Core_Application_App__get_ToastController(uVar3,2,uVar4,0);
		      return;
		    }
		  }
		  param1_00 = param1[6];
		  uVar5 = func_ii_7957(param2,0);
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x100) * 4))
		                    (param1,CONCAT44(uVar3,*(undefined4 *)(*param1 + 0x104)));
		  if (*(int *)(iVar2 + 0x24) + -1 < iVar1) {
		    iVar1 = *(int *)(*(int *)(iVar2 + 0x18) + 0x10) + (iVar1 - *(int *)(iVar2 + 0x24));
		  }
		  uVar3 = ServicesNamespace_ShopService__BuyArtifact(param1_00,uVar5,iVar1 + 1,0,0);
		  uVar4 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (uVar4,param1,Method_Gameplay_Shop_ShopController_OnItemsMovedToShop__,0);
		  uVar3 = ServicesNamespace_MainService__GetUserStats
		                    (uVar3,uVar4,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar3,0);
		  return;
		}
		*/

		}

		// Token: 0x06002052 RID: 8274 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002052")]
		[Address(RVA = "0x71B7", Offset = "0x71B7", VA = "0x71B7")]
		public void MoveItemToLastSelectedOrFirstEmpty(ArtifactData artifactData, bool toNeboMarket)
		{
		/* --- GHIDRA: MoveItemToLastSelectedOrFirstEmpty ---
		void Gameplay_Shop_ShopController__MoveItemToLastSelectedOrFirstEmpty
		               (undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a58309 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFromUser2ShopErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoMoveArtifactFromUser2ShopAns_TypeInfo);
		    DAT_ram_00a58309 = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Shop_ProtoMoveArtifactFromUser2ShopAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Shop_ProtoMoveArtifactFromUser2ShopAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFromUser2ShopErrors___
		                    );
		  if (iVar2 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80ecf697;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ecf697:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar2 + 0x14),param1_00[5],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002053 RID: 8275 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002053")]
		[Address(RVA = "0x71B8", Offset = "0x71B8", VA = "0x71B8")]
		private void OnItemsMovedToShop(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: OnItemsMovedToShop ---
		void Gameplay_Shop_ShopController__OnItemsMovedToShop
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5830a == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEquipFromDropProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Shop_ShopController___c__DisplayClass15_0__TakeoffArtifactFromShop_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopController___c__DisplayClass15_0_TypeInfo);
		    DAT_ram_00a5830a = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_Shop_ShopController___c__DisplayClass15_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80ecf7cd;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ecf7cd:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20);
		  if (param3 == 0) {
		    uVar4 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                      (uVar4,1,3,
		                       Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                      );
		  }
		  else {
		    uVar4 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___StartResolveEmptySlotsProcess
		                      (uVar4,*(undefined4 *)(param2_00 + 0xc),
		                       Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEquipFromDropProcess__
		                      );
		  }
		  param1_00 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_Shop_ShopController___c__DisplayClass15_0__TakeoffArtifactFromShop_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar4,param1_00,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002054 RID: 8276 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002054")]
		[Address(RVA = "0x71B9", Offset = "0x71B9", VA = "0x71B9")]
		public void TakeoffArtifactFromShop(ArtifactData shopArtifact, bool equip = false)
		{
		/* --- GHIDRA: TakeoffArtifactFromShop ---
		void Gameplay_Shop_ShopController__TakeoffArtifactFromShop
		               (undefined4 param1,undefined4 param2,int param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int param2_00;
		  uint *puVar2;
		  undefined4 param1_00;
		  int *param1_01;
		  int iVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a5830b == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_int__int___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		              );
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEquipFromDropProcess__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_int__int__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Shop_ShopController___c__DisplayClass16_0__BuyArtifactFromAnotherShop_b__0__
		              );
		    Mono_Security_ASN1__get_Item(&Gameplay_Shop_ShopController___c__DisplayClass16_0_TypeInfo);
		    DAT_ram_00a5830b = '\x01';
		  }
		  param2_00 = unnamed_function_1417(Gameplay_Shop_ShopController___c__DisplayClass16_0_TypeInfo);
		  *(undefined4 *)(param2_00 + 0xc) = param2;
		  *(undefined4 *)(param2_00 + 8) = param1;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar3 = *param1_01;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + iVar3 + 0x120);
		        goto code_r0x80ecf94d;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ecf94d:
		  iVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_01,puVar2[1]);
		  uVar4 = *(undefined4 *)(*(int *)(iVar3 + 0x14) + 0x20);
		  if (param3 == 0) {
		    uVar4 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___ShowNotAvailableSlotsWindow
		                      (uVar4,1,3,
		                       Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEmptySlotsProcess__
		                      );
		  }
		  else {
		    uVar4 = Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_object___StartResolveEmptySlotsProcess
		                      (uVar4,*(undefined4 *)(param2_00 + 0xc),
		                       Method_Gameplay_Inventory_Controller_Middlewares_InventoryActionsMiddlewareBase_InventoryModel__StartResolveEquipFromDropProcess__
		                      );
		  }
		  param1_00 = unnamed_function_1417(System_Action_OpToken_int__int___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param2_00,
		             Method_Gameplay_Shop_ShopController___c__DisplayClass16_0__BuyArtifactFromAnotherShop_b__0__
		             ,0);
		  ServicesNamespace_MainService__GetUserStats
		            (uVar4,param1_00,0,Method_Utils_OpToken_int__int__AddResultHandler__);
		  return;
		}
		*/

		}

		// Token: 0x06002055 RID: 8277 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002055")]
		[Address(RVA = "0x71BA", Offset = "0x71BA", VA = "0x71BA")]
		public void BuyArtifactFromAnotherShop(ArtifactData shopArtifact, bool equip = false)
		{
		/* --- GHIDRA: BuyArtifactFromAnotherShop ---
		void Gameplay_Shop_ShopController__BuyArtifactFromAnotherShop
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined8 param2_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5830c == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Shop_ShopController_MoveItemFromShopResultHandler__);
		    DAT_ram_00a5830c = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = func_ii_7957(param2,0);
		  uVar1 = ServicesNamespace_ShopService__MoveArtifactFromUserToShop(uVar1,param2_00,param3,0);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Shop_ShopController_MoveItemFromShopResultHandler__,0)
		  ;
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002056 RID: 8278 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002056")]
		[Address(RVA = "0x71BB", Offset = "0x71BB", VA = "0x71BB")]
		private void MoveItemFromShop(ArtifactData shopArtifact, uint destSlotId)
		{
		/* --- GHIDRA: MoveItemFromShop ---
		void Gameplay_Shop_ShopController__MoveItemFromShop(undefined4 param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  int *param1_00;
		  int *param1_01;
		  
		  if (DAT_ram_00a5830d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFromShop2UserErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoMoveArtifactFromShop2UserAns_TypeInfo);
		    DAT_ram_00a5830d = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) &&
		     (Protocol_Shop_ProtoMoveArtifactFromShop2UserAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance
		              (param1_00,Protocol_Shop_ProtoMoveArtifactFromShop2UserAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  iVar2 = UnityEngine_EventSystems_ExecuteEvents__ValidateEventData_object_
		                    (param1_00[3],0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedFromShop2UserErrors___
		                    );
		  if (iVar2 == 0) {
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_01 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_01;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80ecfb61;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_01,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ecfb61:
		    iVar2 = (**(code **)((ulonglong)*puVar3 * 4))(param1_01,puVar3[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar2 + 0x14),param1_00[5],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002057 RID: 8279 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002057")]
		[Address(RVA = "0x71BC", Offset = "0x71BC", VA = "0x71BC")]
		private void MoveItemFromShopResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: MoveItemFromShopResultHandler ---
		void Gameplay_Shop_ShopController__MoveItemFromShopResultHandler
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 param1_00;
		  undefined8 param2_00;
		  undefined8 param3_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5830e == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_OpToken_IMessage__object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__SetCustomData__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Gameplay_Shop_ShopController_BuyArtifactFromShopResultHandler__);
		    DAT_ram_00a5830e = '\x01';
		  }
		  uVar1 = *(undefined4 *)(param1 + 0x18);
		  param2_00 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext
		                        (*(undefined4 *)(param2 + 0x70),0);
		  param3_00 = func_ii_7957(param2,0);
		  uVar1 = ServicesNamespace_ShopService__GetShopItemsInfo(uVar1,param2_00,param3_00,param3,0);
		  uVar1 = DG_Tweening_TweenParams__SetId
		                    (uVar1,param2,Method_Utils_OpToken_IMessage__object__SetCustomData__);
		  param1_00 = unnamed_function_1417(System_Action_OpToken_IMessage__object___TypeInfo);
		  UnityEngine_UIElements_VisualElement__get_layout
		            (param1_00,param1,Method_Gameplay_Shop_ShopController_BuyArtifactFromShopResultHandler__
		             ,0);
		  uVar1 = ServicesNamespace_MainService__GetUserStats
		                    (uVar1,param1_00,0,Method_Utils_OpToken_IMessage__object__AddResultHandler__);
		  Utils_OpToken_int__object___AddHandlers(param1,uVar1,0);
		  return;
		}
		*/

		}

		// Token: 0x06002058 RID: 8280 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002058")]
		[Address(RVA = "0x71BD", Offset = "0x71BD", VA = "0x71BD")]
		private void BuyArtifactFromShop(ArtifactData shopArtifact, uint destSlotId)
		{
		/* --- GHIDRA: BuyArtifactFromShop ---
		void Gameplay_Shop_ShopController__BuyArtifactFromShop(int *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  int iVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  uint *puVar5;
		  int *param1_00;
		  int *param1_01;
		  int *param1_02;
		  undefined4 param3_00;
		  
		  if (DAT_ram_00a5830f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_ArtifactData_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuyArtifactErrors___
		              );
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    Mono_Security_ASN1__get_Item(&Method_Utils_OpToken_IMessage__object__get_Result__);
		    Mono_Security_ASN1__get_Item(&Protocol_Shop_ProtoBuyArtifactAns_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Events_Scopes_ShopScope_ShopEventArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_9179);
		    DAT_ram_00a5830f = '\x01';
		  }
		  MVC_AbstractController__CancelRequests(param1,param2,0);
		  param1_00 = *(int **)(param2 + 0x20);
		  if ((param1_00 != (int *)0x0) && (Protocol_Shop_ProtoBuyArtifactAns_TypeInfo != *param1_00)) {
		    System_Activator__CreateInstance(param1_00,Protocol_Shop_ProtoBuyArtifactAns_TypeInfo);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param1_01 = *(int **)(param2 + 0xc);
		  if (param1_01 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_01 + 0xb8) <
		         (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_01 + 100) +
		                 (uint)*(byte *)(Core_Data_ArtifactData_TypeInfo + 0xb8) * 4 + -4) !=
		        Core_Data_ArtifactData_TypeInfo)) {
		      System_Activator__CreateInstance(param1_01,Core_Data_ArtifactData_TypeInfo);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar2 = Core_Errors_Expected_ExpectedErrorsHandler__HandleErrorChain_object_
		                    (param1_00[3],0,0,
		                     Method_Core_Errors_Expected_ExpectedErrorsHandler_HandleErrorChain_ExpectedBillingErrors__ExpectedBuyArtifactErrors___
		                    );
		  if (iVar2 == 0) {
		    uVar3 = System_Uri___ctor(0);
		    uVar3 = System_Globalization_TimeSpanFormat_FormatLiterals__get_DayHourSep(uVar3,0);
		    if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_GameLocalization_TypeInfo);
		    }
		    uVar4 = Core_Extensions_Dict_CultDicExt__GetTitle(StringLiteral_9179,1,0,1,0,0,0,0);
		    Core_Application_App__get_ToastController(uVar3,1,uVar4,0);
		    if (DAT_ram_00a6456f == '\0') {
		      Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		      DAT_ram_00a6456f = '\x01';
		    }
		    uVar1 = 0;
		    param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		    iVar2 = *param1_02;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar5 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0x120);
		          goto code_r0x80ecfdf9;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar5 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0xc);
		code_r0x80ecfdf9:
		    iVar2 = (**(code **)((ulonglong)*puVar5 * 4))(param1_02,puVar5[1]);
		    Gameplay_Inventory_Controller_InventoryBaseController_object__object___HandleSuccessDismantle
		              (*(undefined4 *)(iVar2 + 0x14),param1_00[4],
		               Method_Gameplay_Inventory_Controller_InventoryBaseController_InventoryModel__InventoryEvents__ParseSlotChanges__
		              );
		    iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x110) * 4))
		                      (param1,*(undefined4 *)(*param1 + 0x114));
		    iVar2 = *(int *)(iVar2 + 0x14);
		    if (iVar2 != 0) {
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),*(undefined4 *)(iVar2 + 0x14));
		    }
		    iVar2 = System_Uri___ctor(0);
		    iVar2 = *(int *)(*(int *)(*(int *)(*(int *)(iVar2 + 0x38) + 0x10) + 0x68) + 8);
		    if (iVar2 != 0) {
		      uVar3 = System_Uri___ctor(0);
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      param3_00 = **(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      uVar4 = unnamed_function_1417(Core_Events_Scopes_ShopScope_ShopEventArgs_TypeInfo);
		      Core_Events_Scopes_UserScope_BaseUserEventArgs__set_UserData
		                (uVar4,uVar3,param3_00,param1_01,0);
		      (**(code **)((ulonglong)*(uint *)(iVar2 + 0xc) * 4))
		                (*(undefined4 *)(iVar2 + 0x20),uVar4,*(undefined4 *)(iVar2 + 0x14));
		    }
		  }
		  return;
		}
		*/

		}

		// Token: 0x06002059 RID: 8281 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002059")]
		[Address(RVA = "0x71BE", Offset = "0x71BE", VA = "0x71BE")]
		private void BuyArtifactFromShopResultHandler(OpToken<IMessage, object> op)
		{
		/* --- GHIDRA: BuyArtifactFromShopResultHandler ---
		void Gameplay_Shop_ShopController__BuyArtifactFromShopResultHandler(int param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a58310 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ShopModel__ShopEvents__Dispose__);
		    DAT_ram_00a58310 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x18) = 0;
		  MVC_AbstractController_object__object____ctor
		            (param1,Method_MVC_AbstractController_ShopModel__ShopEvents__Dispose__);
		  return;
		}
		*/

		}

		// Token: 0x0600205A RID: 8282 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600205A")]
		[Address(RVA = "0x71BF", Offset = "0x71BF", VA = "0x71BF", Slot = "5")]
		public override void Dispose()
		{
		}

		// Token: 0x040011A6 RID: 4518
		[Token(Token = "0x40011A6")]
		[FieldOffset(Offset = "0x18")]
		private ShopService _shopService;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_ItemsRequested ---
		void Gameplay_Shop_ShopController__set_ItemsRequested
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a58303 == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_MVC_AbstractController_ShopModel__ShopEvents___ctor__);
		    Mono_Security_ASN1__get_Item(&Method_Core_Net_ServiceFactory_GetService_ShopService___);
		    Mono_Security_ASN1__get_Item(&Core_Net_ServiceFactory_TypeInfo);
		    DAT_ram_00a58303 = '\x01';
		  }
		  Gameplay_Combat_AbstractCombat_object__object__object__object__object___set_User
		            (param1,param2,param3,Method_MVC_AbstractController_ShopModel__ShopEvents___ctor__);
		  if (*(int *)(Core_Net_ServiceFactory_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_Net_ServiceFactory_TypeInfo);
		  }
		  uVar1 = Core_Gameplay_Managers_LoggedManager__RequestLogin
		                    (Method_Core_Net_ServiceFactory_GetService_ShopService___);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  return;
		}
		*/


		/* --- GHIDRA: Buy ---
		void Gameplay_Competition_Control_Sections_ShopController__Buy
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4,
		               undefined4 param5,undefined4 param6)
		
		{
		  if (DAT_ram_00a63b0c == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_ShopModel__ShopEvents__ShopController__ShopView___ctor__
		              );
		    DAT_ram_00a63b0c = '\x01';
		  }
		  MVC_AbstractCozyViewMediator_object__object__object__object____ctor
		            (param1,param2,param3,param4,param5,
		             Method_MVC_AbstractCozyViewMediator_ShopModel__ShopEvents__ShopController__ShopView___ctor__
		            );
		  return;
		}
		*/

}
