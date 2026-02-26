using System;
using System.Runtime.CompilerServices;
using Gameplay.GameEvents.Control;
using Il2CppDummyDll;

namespace Gameplay.GameEvents.Model.ActionsOnEvents
{
	// Token: 0x020007D8 RID: 2008
	[Token(Token = "0x20007D8")]
	public class RevengeActionOnEvent_20 : AbstractActionOnEvent
	{
		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x000098D0 File Offset: 0x00007AD0
		[Token(Token = "0x1700092F")]
		public override uint SortOrder
		{
			[Token(Token = "0x6002F09")]
			[Address(RVA = "0x7F76", Offset = "0x7F76", VA = "0x7F76", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return 0U;
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0A")]
		[Address(RVA = "0x7F77", Offset = "0x7F77", VA = "0x7F77", Slot = "6")]
		public override void Execute(GameEventsController controller)
		{
		}

		// Token: 0x06002F0B RID: 12043 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002F0B")]
		[Address(RVA = "0x7F78", Offset = "0x7F78", VA = "0x7F78")]
		public RevengeActionOnEvent_20()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_SortOrder ---
		void Gameplay_GameEvents_Model_ActionsOnEvents_RevengeActionOnEvent_20__get_SortOrder
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  int iVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined8 param2_00;
		  undefined8 uVar4;
		  int *piVar5;
		  int iVar6;
		  int iVar7;
		  uint uVar8;
		  int local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a57502 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__UserData__TryGetValue__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_ulong__ClanShortInfo__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_GameEventData__Add__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_AbstractTag__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    DAT_ram_00a57502 = '\x01';
		  }
		  local_4 = 0;
		  local_8 = 0;
		  if (0 < *(int *)(*(int *)(*(int *)(param1 + 0x10) + 0x28) + 0xc)) {
		    param2_00 = func_ii_7271(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0x24) + 0x30),0,
		                             Method_Google_Protobuf_Collections_RepeatedField_ulong__get_Item__);
		    uVar4 = param2_00;
		    iVar1 = func_ii_7090(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0x18) + 0x14),param2_00,
		                         &local_4,
		                         Method_System_Collections_Generic_Dictionary_ulong__UserData__TryGetValue__
		                        );
		    uVar3 = (undefined4)((ulonglong)uVar4 >> 0x20);
		    if (iVar1 == 0) {
		      iVar1 = func_ii_7090(*(undefined4 *)(*(int *)(*(int *)(param1 + 0x10) + 0x18) + 0x18),
		                           param2_00,&local_8,
		                           Method_System_Collections_Generic_Dictionary_ulong__ClanShortInfo__TryGetValue__
		                          );
		      uVar3 = (undefined4)((ulonglong)param2_00 >> 0x20);
		      if (iVar1 != 0) {
		        if (DAT_ram_00a6456f == '\0') {
		          Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		          DAT_ram_00a6456f = '\x01';
		        }
		        piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		        iVar1 = *piVar5;
		        if (*(ushort *)(iVar1 + 0xb6) != 0) {
		          uVar8 = 0;
		          do {
		            if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		              puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x110
		                               );
		              goto code_r0x80d9b694;
		            }
		            uVar8 = uVar8 + 1;
		          } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		        }
		        puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80d9b694:
		        uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar3,puVar2[1]));
		        Core_Gameplay_Managers_WorldManager__GoToUserIsleById
		                  (uVar3,*(undefined8 *)(local_8 + 0x10),0);
		        iVar1 = Method_System_Collections_Generic_List_GameEventData__Add__;
		        iVar6 = *(int *)(param1 + 0x10);
		        iVar7 = *(int *)(*(int *)(iVar6 + 0x18) + 0x48);
		        *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		        uVar8 = *(uint *)(iVar7 + 0xc);
		        if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		          *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		          *(int *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = iVar6;
		        }
		        else {
		          System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                    (iVar7,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		        }
		      }
		    }
		    else {
		      if (DAT_ram_00a6456f == '\0') {
		        Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		        DAT_ram_00a6456f = '\x01';
		      }
		      uVar8 = 0;
		      piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		      iVar1 = *piVar5;
		      if (*(ushort *)(iVar1 + 0xb6) != 0) {
		        do {
		          if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8)) {
		            puVar2 = (uint *)(*(int *)(*(int *)(iVar1 + 0x58) + uVar8 * 8 + 4) * 8 + iVar1 + 0x110);
		            goto code_r0x80d9b551;
		          }
		          uVar8 = uVar8 + 1;
		        } while (*(ushort *)(iVar1 + 0xb6) != uVar8);
		      }
		      puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,10);
		code_r0x80d9b551:
		      uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,CONCAT44(uVar3,puVar2[1]));
		      uVar4 = System_Collections_Generic_LinkedList_Enumerator_object___MoveNext(local_4,0);
		      Core_Gameplay_Managers_WorldManager__GoHome(uVar3,uVar4,0);
		      iVar1 = Method_System_Collections_Generic_List_GameEventData__Add__;
		      iVar6 = *(int *)(param1 + 0x10);
		      iVar7 = *(int *)(*(int *)(iVar6 + 0x18) + 0x48);
		      *(int *)(iVar7 + 0x10) = *(int *)(iVar7 + 0x10) + 1;
		      uVar8 = *(uint *)(iVar7 + 0xc);
		      if (uVar8 < *(uint *)(*(int *)(iVar7 + 8) + 0xc)) {
		        *(uint *)(iVar7 + 0xc) = uVar8 + 1;
		        *(int *)(*(int *)(iVar7 + 8) + uVar8 * 4 + 0x10) = iVar6;
		      }
		      else {
		        System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                  (iVar7,iVar6,*(undefined4 *)(*(int *)(*(int *)(iVar1 + 0x10) + 0x60) + 0x38));
		      }
		    }
		  }
		  return;
		}
		*/

}
