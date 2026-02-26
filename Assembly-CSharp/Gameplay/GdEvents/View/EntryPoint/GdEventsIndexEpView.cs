using System;
using AssetContent;
using Core.MVC.Interfaces;
using Il2CppDummyDll;
using UI.Elements.Counters;
using UnityEngine;

namespace Gameplay.GdEvents.View.EntryPoint
{
	// Token: 0x0200074A RID: 1866
	[Token(Token = "0x200074A")]
	public class GdEventsIndexEpView : AbstractEpView
	{
		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x06002C78 RID: 11384 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700088A")]
		public CounterAutoHide Counter
		{
			[Token(Token = "0x6002C78")]
			[Address(RVA = "0x7D07", Offset = "0x7D07", VA = "0x7D07")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x06002C79 RID: 11385 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700088B")]
		public GameAssetViewRawImage View
		{
			[Token(Token = "0x6002C79")]
			[Address(RVA = "0x7D08", Offset = "0x7D08", VA = "0x7D08")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002C7A RID: 11386 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7A")]
		[Address(RVA = "0x7D09", Offset = "0x7D09", VA = "0x7D09")]
		private void OnDestroy()
		{
		/* --- GHIDRA: OnDestroy ---
		void Gameplay_GdEvents_View_EntryPoint_GdEventsIndexEpView__OnDestroy(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 param2_00;
		  undefined4 param3;
		  undefined4 param4;
		  int *piVar3;
		  int iVar4;
		  undefined4 param5;
		  int iVar5;
		  
		  if (DAT_ram_00a5a2c4 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a2c4 = '\x01';
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0xe0);
		        goto code_r0x811f6c96;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,4);
		code_r0x811f6c96:
		  param2_00 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x278);
		        goto code_r0x811f6d42;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x37);
		code_r0x811f6d42:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x10);
		  param3 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x100) * 4))
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x278);
		        goto code_r0x811f6e07;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x37);
		code_r0x811f6e07:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  iVar5 = **(int **)(iVar4 + 0x10);
		  param4 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0x110) * 4))
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
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x278);
		        goto code_r0x811f6ecc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_Gameplay_IGame_TypeInfo,0x37);
		code_r0x811f6ecc:
		  iVar4 = (**(code **)((ulonglong)*puVar2 * 4))(piVar3,puVar2[1]);
		  param5 = *(undefined4 *)(iVar4 + 0x10);
		  uVar1 = 0;
		  piVar3 = (int *)unnamed_function_1417
		                            (
		                            Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator_TypeInfo
		                            );
		  Gameplay_GdEvents_Control_EntryPoint_GdEventsIndexEpViewMediator__Dispose
		            (piVar3,param2_00,param3,param4,param5,0);
		  *(int **)(param1 + 0x1c) = piVar3;
		  iVar4 = *piVar3;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_MVC_Interfaces_IViewMediator_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)
		         ) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x100);
		        goto code_r0x811f6f75;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar3,Core_MVC_Interfaces_IViewMediator_TypeInfo,8);
		code_r0x811f6f75:
		  (**(code **)((ulonglong)*puVar2 * 4))(piVar3,param1,puVar2[1]);
		  return;
		}
		*/

		}

		// Token: 0x06002C7B RID: 11387 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7B")]
		[Address(RVA = "0x7D0A", Offset = "0x7D0A", VA = "0x7D0A")]
		private void Start()
		{
		}

		// Token: 0x06002C7C RID: 11388 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002C7C")]
		[Address(RVA = "0x7D0B", Offset = "0x7D0B", VA = "0x7D0B")]
		public GdEventsIndexEpView()
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_GdEvents_View_EntryPoint_GdEventsIndexEpView___ctor(int param1,undefined4 param2)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5a2c5 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData___TypeInfo);
		    Mono_Security_ASN1__get_Item(&UI_Tabs_TabBarItemData_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8326);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8327);
		    Mono_Security_ASN1__get_Item(&StringLiteral_8325);
		    DAT_ram_00a5a2c5 = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(UI_Tabs_TabBarItemData___TypeInfo,3);
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = 1;
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar3 = func_ii_7508(StringLiteral_8326,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = 2;
		  uVar3 = func_ii_7508(StringLiteral_8327,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[5] = iVar2;
		  iVar2 = unnamed_function_1417(UI_Tabs_TabBarItemData_TypeInfo);
		  *(undefined4 *)(iVar2 + 0x14) = 3;
		  uVar3 = func_ii_7508(StringLiteral_8325,1,0,1,0,0,0,0);
		  *(undefined4 *)(iVar2 + 0x10) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[6] = iVar2;
		    *(int **)(param1 + 8) = piVar1;
		    return;
		  }
		  uVar3 = func_ii_1083();
		  func_ii_1050(uVar3,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

		}

		// Token: 0x0400186D RID: 6253
		[Token(Token = "0x400186D")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private GameAssetViewRawImage _view;

		// Token: 0x0400186E RID: 6254
		[Token(Token = "0x400186E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private CounterAutoHide _counter;

		// Token: 0x0400186F RID: 6255
		[Token(Token = "0x400186F")]
		[FieldOffset(Offset = "0x1C")]
		private IViewMediator _mediator;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_View ---
		void Gameplay_GdEvents_View_EntryPoint_GdEventsIndexEpView__get_View(int param1,undefined4 param2)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2c3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_MVC_Interfaces_IViewMediator_TypeInfo);
		    DAT_ram_00a5a2c3 = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 0x1c);
		  if (param1_00 != (int *)0x0) {
		    uVar1 = 0;
		    iVar3 = *param1_00;
		    if (*(ushort *)(iVar3 + 0xb6) != 0) {
		      do {
		        if (Core_MVC_Interfaces_IViewMediator_TypeInfo ==
		            *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		          goto code_r0x811f6bbb;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param1_00,Core_MVC_Interfaces_IViewMediator_TypeInfo,0);
		code_r0x811f6bbb:
		    (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  }
		  return;
		}
		*/

}
