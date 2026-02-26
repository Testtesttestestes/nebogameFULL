using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Accounts.Model.Data;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Isles.User.Model
{
	// Token: 0x02000D2B RID: 3371
	[Token(Token = "0x2000D2B")]
	public class UserIsleAccountMarkerData
	{
		// Token: 0x06005265 RID: 21093 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005265")]
		[Address(RVA = "0xA03C", Offset = "0xA03C", VA = "0xA03C")]
		private UserIsleAccountMarkerData(IAccountDataDecorator account)
		{
		}

		// Token: 0x170010C5 RID: 4293
		// (get) Token: 0x06005266 RID: 21094 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005267 RID: 21095 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C5")]
		public IAccountDataDecorator Account
		{
			[Token(Token = "0x6005266")]
			[Address(RVA = "0xA03D", Offset = "0xA03D", VA = "0xA03D")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005267")]
			[Address(RVA = "0xA03E", Offset = "0xA03E", VA = "0xA03E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170010C6 RID: 4294
		// (get) Token: 0x06005268 RID: 21096 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005269 RID: 21097 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170010C6")]
		public Point Position
		{
			[Token(Token = "0x6005268")]
			[Address(RVA = "0xA03F", Offset = "0xA03F", VA = "0xA03F")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005269")]
			[Address(RVA = "0xA040", Offset = "0xA040", VA = "0xA040")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600526A RID: 21098 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600526A")]
		[Address(RVA = "0xA041", Offset = "0xA041", VA = "0xA041")]
		public static UserIsleAccountMarkerData Create(UserIsleModel model, IAccountDataDecorator account)
		{
		/* --- GHIDRA: Create ---
		int Gameplay_Isles_User_Model_UserIsleAccountMarkerData__Create(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_01;
		  uint uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a58d82 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_UserIsleAccountMarkerData__TypeInfo);
		    DAT_ram_00a58d82 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_UserIsleAccountMarkerData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_UserIsleAccountMarkerData___ctor__);
		  iVar3 = *(int *)(param1 + 0x4c);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      param1_01 = *(int **)(iVar3 + iVar5 * 4 + 0x10);
		      if (*(char *)(*(int *)(param1 + 0x34) + 0x2d) != '\0') {
		        iVar6 = *param1_01;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar4 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar7) {
		              puVar1 = (uint *)(piVar7[1] * 8 + iVar6 + 200);
		              goto code_r0x80fa4ff4;
		            }
		            uVar4 = uVar4 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		        }
		        puVar1 = (uint *)func_ii_1080(param1_01,
		                                      Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1)
		        ;
		code_r0x80fa4ff4:
		        iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		        if (*(int *)(iVar6 + 0xc) == 1) {
		          uVar2 = Gameplay_Isles_User_Model_UserIsleAccountMarkerData__set_Position
		                            (param1,param1_01,puVar1);
		          iVar6 = Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__;
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar4 = *(uint *)(param1_00 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		            *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,uVar2,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      if (*(char *)(*(int *)(param1 + 0x34) + 0x2c) != '\0') {
		        iVar6 = *param1_01;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar4 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar7) {
		              puVar1 = (uint *)(piVar7[1] * 8 + iVar6 + 200);
		              goto code_r0x80fa50e5;
		            }
		            uVar4 = uVar4 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		        }
		        puVar1 = (uint *)func_ii_1080(param1_01,
		                                      Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1)
		        ;
		code_r0x80fa50e5:
		        iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		        if (*(int *)(iVar6 + 0xc) == 5) {
		          uVar2 = Gameplay_Isles_User_Model_UserIsleAccountMarkerData__set_Position
		                            (param1,param1_01,puVar1);
		          iVar6 = Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__;
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar4 = *(uint *)(param1_00 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		            *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,uVar2,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return param1_00;
		}
		*/

		/* --- GHIDRA: Create ---
		int Gameplay_Isles_User_Model_UserIsleAccountMarkerData__Create(int param1,undefined4 param2)
		
		{
		  int param1_00;
		  uint *puVar1;
		  undefined4 uVar2;
		  int iVar3;
		  int *param1_01;
		  uint uVar4;
		  int iVar5;
		  int iVar6;
		  int *piVar7;
		  
		  iVar5 = 0;
		  if (DAT_ram_00a58d82 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_UserIsleAccountMarkerData___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&System_Collections_Generic_List_UserIsleAccountMarkerData__TypeInfo);
		    DAT_ram_00a58d82 = '\x01';
		  }
		  param1_00 = unnamed_function_1417
		                        (System_Collections_Generic_List_UserIsleAccountMarkerData__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (param1_00,Method_System_Collections_Generic_List_UserIsleAccountMarkerData___ctor__);
		  iVar3 = *(int *)(param1 + 0x4c);
		  if (0 < *(int *)(iVar3 + 0xc)) {
		    do {
		      param1_01 = *(int **)(iVar3 + iVar5 * 4 + 0x10);
		      if (*(char *)(*(int *)(param1 + 0x34) + 0x2d) != '\0') {
		        iVar6 = *param1_01;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar4 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar7) {
		              puVar1 = (uint *)(piVar7[1] * 8 + iVar6 + 200);
		              goto code_r0x80fa4ff4;
		            }
		            uVar4 = uVar4 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		        }
		        puVar1 = (uint *)func_ii_1080(param1_01,
		                                      Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1)
		        ;
		code_r0x80fa4ff4:
		        iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		        if (*(int *)(iVar6 + 0xc) == 1) {
		          uVar2 = Gameplay_Isles_User_Model_UserIsleAccountMarkerData__set_Position
		                            (param1,param1_01,puVar1);
		          iVar6 = Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__;
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar4 = *(uint *)(param1_00 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		            *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,uVar2,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      if (*(char *)(*(int *)(param1 + 0x34) + 0x2c) != '\0') {
		        iVar6 = *param1_01;
		        if (*(ushort *)(iVar6 + 0xb6) != 0) {
		          uVar4 = 0;
		          do {
		            piVar7 = (int *)(*(int *)(iVar6 + 0x58) + uVar4 * 8);
		            if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo == *piVar7) {
		              puVar1 = (uint *)(piVar7[1] * 8 + iVar6 + 200);
		              goto code_r0x80fa50e5;
		            }
		            uVar4 = uVar4 + 1;
		          } while (*(ushort *)(iVar6 + 0xb6) != uVar4);
		        }
		        puVar1 = (uint *)func_ii_1080(param1_01,
		                                      Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1)
		        ;
		code_r0x80fa50e5:
		        iVar6 = (**(code **)((ulonglong)*puVar1 * 4))(param1_01,puVar1[1]);
		        if (*(int *)(iVar6 + 0xc) == 5) {
		          uVar2 = Gameplay_Isles_User_Model_UserIsleAccountMarkerData__set_Position
		                            (param1,param1_01,puVar1);
		          iVar6 = Method_System_Collections_Generic_List_UserIsleAccountMarkerData__Add__;
		          *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		          uVar4 = *(uint *)(param1_00 + 0xc);
		          if (uVar4 < *(uint *)(*(int *)(param1_00 + 8) + 0xc)) {
		            *(uint *)(param1_00 + 0xc) = uVar4 + 1;
		            *(undefined4 *)(*(int *)(param1_00 + 8) + uVar4 * 4 + 0x10) = uVar2;
		          }
		          else {
		            System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                      (param1_00,uVar2,
		                       *(undefined4 *)(*(int *)(*(int *)(iVar6 + 0x10) + 0x60) + 0x38));
		          }
		        }
		      }
		      iVar5 = iVar5 + 1;
		    } while (iVar5 < *(int *)(iVar3 + 0xc));
		  }
		  return param1_00;
		}
		*/

			return null;
		}

		// Token: 0x0600526B RID: 21099 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600526B")]
		[Address(RVA = "0xA042", Offset = "0xA042", VA = "0xA042")]
		public static List<UserIsleAccountMarkerData> Create(UserIsleModel model)
		{
			return null;
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_Position ---
		int Gameplay_Isles_User_Model_UserIsleAccountMarkerData__set_Position
		              (int param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a58d81 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Isles_User_Model_UserIsleAccountMarkerData_TypeInfo);
		    DAT_ram_00a58d81 = '\x01';
		  }
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		        goto code_r0x80fa4dc0;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo,1
		                               );
		code_r0x80fa4dc0:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  if (*(int *)(iVar6 + 0xc) == 1) {
		    iVar6 = unnamed_function_1417(Gameplay_Isles_User_Model_UserIsleAccountMarkerData_TypeInfo);
		    *(int **)(iVar6 + 8) = param2;
		    piVar5 = (int *)(*(int *)(param1 + 0x38) + 0x18);
		  }
		  else {
		    uVar1 = 0;
		    iVar6 = *param2;
		    if (*(ushort *)(iVar6 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		          puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 200);
		          goto code_r0x80fa4e61;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		    }
		    puVar2 = (uint *)func_ii_1080(param2,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,1);
		code_r0x80fa4e61:
		    iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		    if (*(int *)(iVar6 + 0xc) != 5) {
		      uVar3 = unnamed_function_2232(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		      iVar6 = Unity_Properties_PropertyMember___ctor(1,uVar3,param2);
		      local_4 = *(undefined4 *)(iVar6 + 0xc);
		      uVar3 = func_ii_1081(DAT_ram_00a66958,&local_4);
		      uVar4 = unnamed_function_2232(&StringLiteral_17180);
		      uVar3 = func_ii_4419(uVar4,uVar3,0);
		      uVar4 = unnamed_function_2232(&System_Exception_TypeInfo);
		      uVar4 = unnamed_function_1417(uVar4);
		      System_String__Concat(uVar4,uVar3,0);
		      uVar3 = unnamed_function_2232
		                        (&Method_Gameplay_Isles_User_Model_UserIsleAccountMarkerData_Create__);
		      func_ii_1050(uVar4,uVar3);
		      do {
		        halt_trap();
		      } while( true );
		    }
		    iVar6 = unnamed_function_1417(Gameplay_Isles_User_Model_UserIsleAccountMarkerData_TypeInfo);
		    *(int **)(iVar6 + 8) = param2;
		    piVar5 = (int *)(*(int *)(param1 + 0x38) + 0x14);
		  }
		  *(undefined4 *)(iVar6 + 0xc) = *(undefined4 *)(*piVar5 + 0xc);
		  return iVar6;
		}
		*/

}
