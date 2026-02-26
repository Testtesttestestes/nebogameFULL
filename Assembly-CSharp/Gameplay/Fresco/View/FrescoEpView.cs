using System;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using UnityEngine;
using Utils;

namespace Gameplay.Fresco.View
{
	// Token: 0x020007EF RID: 2031
	[Token(Token = "0x20007EF")]
	[AddComponentMenu("Fresco/View/EntryPoint/FrescoEpView")]
	public class FrescoEpView : MonoBehaviour
	{
		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x06002FB9 RID: 12217 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700095A")]
		public FrescoFieldMini Field
		{
			[Token(Token = "0x6002FB9")]
			[Address(RVA = "0x801F", Offset = "0x801F", VA = "0x801F")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x06002FBA RID: 12218 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700095B")]
		public MonoPointerClickHandler ClickSource
		{
			[Token(Token = "0x6002FBA")]
			[Address(RVA = "0x8020", Offset = "0x8020", VA = "0x8020")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002FBB RID: 12219 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBB")]
		[Address(RVA = "0x8021", Offset = "0x8021", VA = "0x8021")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Fresco_View_FrescoEpView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  int iVar5;
		  
		  if (DAT_ram_00a5755e == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Fresco_Controller_FrescoEpViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5755e = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a8);
		        goto code_r0x80da8650;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3d);
		code_r0x80da8650:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x10);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar5 + 0x104));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a8);
		        goto code_r0x80da8715;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3d);
		code_r0x80da8715:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x10);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                     (*(int **)(iVar4 + 0x10),*(undefined4 *)(iVar5 + 0x114));
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar3 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a8);
		        goto code_r0x80da87da;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3d);
		code_r0x80da87da:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x10);
		  piVar3 = (int *)unnamed_function_1417(Gameplay_Fresco_Controller_FrescoEpViewMediator_TypeInfo);
		  if (DAT_ram_00a575d7 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEpView___ctor__
		              );
		    DAT_ram_00a575d7 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_FrescoModel__FrescoEvents__FrescoController__FrescoEpView___ctor__
		            );
		  *(int **)(param1 + 0x18) = piVar3;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x80da88a7;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x80da88a7:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002FBC RID: 12220 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBC")]
		[Address(RVA = "0x8022", Offset = "0x8022", VA = "0x8022")]
		private void Start()
		{
		}

		// Token: 0x06002FBD RID: 12221 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002FBD")]
		[Address(RVA = "0x8023", Offset = "0x8023", VA = "0x8023")]
		public FrescoEpView()
		{
		/* --- GHIDRA: .ctor ---
		undefined8 Gameplay_Fresco_View_FrescoEpView___ctor(int param1,undefined4 param2)
		
		{
		  return *(undefined8 *)(*(int *)(param1 + 0x4c) + 0x10);
		}
		*/

		}

		// Token: 0x04001A12 RID: 6674
		[Token(Token = "0x4001A12")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickSource;

		// Token: 0x04001A13 RID: 6675
		[Token(Token = "0x4001A13")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private FrescoFieldMini _field;

		// Token: 0x04001A14 RID: 6676
		[Token(Token = "0x4001A14")]
		[FieldOffset(Offset = "0x18")]
		private IViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ClickSource ---
		void Gameplay_Fresco_View_FrescoEpView__get_ClickSource(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5755d == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5755d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x18);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x80da8575;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x80da8575:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return;
		}
		*/

}
