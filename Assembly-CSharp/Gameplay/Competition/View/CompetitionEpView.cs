using System;
using AssetContent;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using TMPro;
using UI.Elements.Counters;
using UnityEngine;
using Utils;

namespace Gameplay.Competition.View
{
	// Token: 0x020008D8 RID: 2264
	[Token(Token = "0x20008D8")]
	[AddComponentMenu("Competition/View/EntryPoint/CompetitionEpView")]
	public class CompetitionEpView : MonoBehaviour
	{
		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x0600354E RID: 13646 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A83")]
		public CounterAutoHide Counter
		{
			[Token(Token = "0x600354E")]
			[Address(RVA = "0x8571", Offset = "0x8571", VA = "0x8571")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x0600354F RID: 13647 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A84")]
		public GameImage Image
		{
			[Token(Token = "0x600354F")]
			[Address(RVA = "0x8572", Offset = "0x8572", VA = "0x8572")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06003550 RID: 13648 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000A85")]
		public MonoPointerClickHandler ClickSource
		{
			[Token(Token = "0x6003550")]
			[Address(RVA = "0x8573", Offset = "0x8573", VA = "0x8573")]
			get
			{
				return null;
			}
		}

		// Token: 0x06003551 RID: 13649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003551")]
		[Address(RVA = "0x8574", Offset = "0x8574", VA = "0x8574")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_Competition_View_CompetitionEpView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  int *piVar3;
		  int iVar4;
		  undefined4 param4;
		  int iVar5;
		  
		  if (DAT_ram_00a63a80 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Competition_Control_CompetitionEpViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a63a80 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a0);
		        goto code_r0x82335407;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x82335407:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
		                        (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x104));
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a0);
		        goto code_r0x823354cc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x823354cc:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x14);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
		                     (*(int **)(iVar4 + 0x14),*(undefined4 *)(iVar5 + 0x114));
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x2a0);
		        goto code_r0x82335591;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x3c);
		code_r0x82335591:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param4 = *(undefined4 *)(iVar4 + 0x14);
		  piVar3 = (int *)unnamed_function_1417
		                            (Gameplay_Competition_Control_CompetitionEpViewMediator_TypeInfo);
		  if (DAT_ram_00a63ad4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView___ctor__
		              );
		    DAT_ram_00a63ad4 = '\x01';
		  }
		  MVC_AbstractController_object__object___set_Model
		            (piVar3,param2_00,param3,param4,
		             Method_MVC_AbstractCozyViewMediator_CompetitionModel__CompetitionEvents__CompetitionController__CompetitionEpView___ctor__
		            );
		  *(int **)(param1 + 0x20) = piVar3;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x8233565e;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x8233565e:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06003552 RID: 13650 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003552")]
		[Address(RVA = "0x8575", Offset = "0x8575", VA = "0x8575")]
		private void Start()
		{
		/* --- GHIDRA: Start ---
		void Gameplay_Competition_View_CompetitionEpView__Start
		               (int param1,undefined8 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  int *piVar2;
		  int iVar3;
		  undefined8 local_8;
		  
		  piVar2 = *(int **)(param1 + 0x18);
		  local_8 = param2;
		  uVar1 = func_ii_8783(&local_8,0);
		  iVar3 = *piVar2;
		  (**(code **)((ulonglong)*(uint *)(iVar3 + 0x2d0) * 4))
		            (piVar2,uVar1,*(undefined4 *)(iVar3 + 0x2d4));
		  return;
		}
		*/

		}

		// Token: 0x06003553 RID: 13651 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003553")]
		[Address(RVA = "0x8576", Offset = "0x8576", VA = "0x8576")]
		public void SetOwnedRatingValue(ulong value)
		{
		}

		// Token: 0x06003554 RID: 13652 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003554")]
		[Address(RVA = "0x8577", Offset = "0x8577", VA = "0x8577")]
		public CompetitionEpView()
		{
		}

		// Token: 0x04001D25 RID: 7461
		[Token(Token = "0x4001D25")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private MonoPointerClickHandler _clickSource;

		// Token: 0x04001D26 RID: 7462
		[Token(Token = "0x4001D26")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameImage _image;

		// Token: 0x04001D27 RID: 7463
		[Token(Token = "0x4001D27")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private TextMeshProUGUI _ownedRatingValue;

		// Token: 0x04001D28 RID: 7464
		[Token(Token = "0x4001D28")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x04001D29 RID: 7465
		[Token(Token = "0x4001D29")]
		[FieldOffset(Offset = "0x20")]
		private IViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_ClickSource ---
		void Gameplay_Competition_View_CompetitionEpView__get_ClickSource(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a63a7f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a63a7f = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x20);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x8233532c;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x8233532c:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return;
		}
		*/

}
