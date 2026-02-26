using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D3 RID: 2003
	[Token(Token = "0x20007D3")]
	public class CollectionActionOnEvent_19 : AbstractActionOnEvent
	{
		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x06002EFA RID: 12026 RVA: 0x00009858 File Offset: 0x00007A58
		[Token(Token = "0x1700092A")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002EFA")]
			[Address(RVA = "0x7F67", Offset = "0x7F67", VA = "0x7F67", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002EFB RID: 12027 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFB")]
		[Address(RVA = "0x7F68", Offset = "0x7F68", VA = "0x7F68", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002EFC RID: 12028 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002EFC")]
		[Address(RVA = "0x7F69", Offset = "0x7F69", VA = "0x7F69")]
		public CollectionActionOnEvent_19()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_CollectionActionOnEvent_19__get_SortOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int *param1_00;
		  uint *puVar1;
		  undefined4 param1_01;
		  int iVar2;
		  int *param1_02;
		  int iVar3;
		  int iVar4;
		  double dVar5;
		  double dVar6;
		  uint uVar7;
		  
		  iVar4 = 0;
		  if (DAT_ram_00a574fe == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_GameEvents_Model_Tags_CollectionsTag_33_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		    DAT_ram_00a574fe = '\x01';
		  }
		  iVar2 = *(int *)(*(int *)(*(int *)(param1 + 0x10) + 0x2c) + 0xc);
		  if (0 < iVar2) {
		    do {
		      param1_00 = (int *)System_Linq_Enumerable__ToList_object_
		                                   (*(undefined4 *)(*(int *)(param1 + 0x10) + 0x2c),iVar4,
		                                    Method_System_Collections_Generic_List_AbstractTag__get_Item__);
		      if (*(int *)(param1_00[3] + 0xc) == 0x21) {
		        if (((uint)*(byte *)(*param1_00 + 0xb8) <
		             (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_CollectionsTag_33_TypeInfo + 0xb8)) ||
		           (*(int *)(*(int *)(*param1_00 + 100) +
		                     (uint)*(byte *)(Gameplay_GameEvents_Model_Tags_CollectionsTag_33_TypeInfo +
		                                    0xb8) * 4 + -4) !=
		            Gameplay_GameEvents_Model_Tags_CollectionsTag_33_TypeInfo)) {
		          System_Activator__CreateInstance
		                    (param1_00,Gameplay_GameEvents_Model_Tags_CollectionsTag_33_TypeInfo);
		          do {
		            halt_trap();
		          } while( true );
		        }
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        param1_02 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar4 = *param1_02;
		        if (*(ushort *)(iVar4 + 0xb6) == 0) goto code_r0x80d9aa36;
		        uVar7 = 0;
		        goto code_r0x80d9a9fe;
		      }
		      iVar4 = iVar4 + 1;
		    } while (iVar4 != iVar2);
		  }
		  return;
		  while (uVar7 = uVar7 + 1, *(ushort *)(iVar4 + 0xb6) != uVar7) {
		code_r0x80d9a9fe:
		    if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8)) {
		      puVar1 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar7 * 8 + 4) * 8 + iVar4 + 0x280);
		      goto code_r0x80d9aa40;
		    }
		  }
		code_r0x80d9aa36:
		  puVar1 = (uint *)func_ii_1080(param1_02,Core_Gameplay_IGame_TypeInfo,0x38);
		code_r0x80d9aa40:
		  param1_01 = (**(code **)((ulonglong)*puVar1 * 4))(param1_02,puVar1[1]);
		  dVar5 = *(double *)(param1_00[5] + 0x18);
		  if (dVar5 < 4294967296.0 && 0.0 <= dVar5) {
		    iVar4 = (int)dVar5;
		  }
		  else {
		    iVar4 = 0;
		  }
		  if (ABS(dVar5) < 2147483648.0) {
		    iVar2 = (int)dVar5;
		  }
		  else {
		    iVar2 = -0x80000000;
		  }
		  dVar6 = *(double *)(param1_00[5] + 0x10);
		  if (dVar6 < 4294967296.0 && 0.0 <= dVar6) {
		    iVar3 = (int)dVar6;
		  }
		  else {
		    iVar3 = 0;
		  }
		  if (0.0 <= dVar5) {
		    iVar2 = iVar4;
		  }
		  if (ABS(dVar6) < 2147483648.0) {
		    iVar4 = (int)dVar6;
		  }
		  else {
		    iVar4 = -0x80000000;
		  }
		  if (0.0 <= dVar6) {
		    iVar4 = iVar3;
		  }
		  Core_Gameplay_Managers_CollectionsManager__ShowCollectionsWindow(param1_01,iVar4,iVar2,0);
		  return;
		}
		*/

}
