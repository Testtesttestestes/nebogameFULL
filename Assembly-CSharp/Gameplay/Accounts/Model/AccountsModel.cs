using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data;
using Core.Dict;
using Core.Gameplay.Managers;
using Gameplay.Accounts.Model.Data;
using Gameplay.Clans.Model;
using Il2CppDummyDll;
using MVC;
using Protocol.Dic;

namespace Gameplay.Accounts.Model
{
	// Token: 0x02000DD9 RID: 3545
	[Token(Token = "0x2000DD9")]
	public class AccountsModel : AbstractModel
	{
		// Token: 0x17001198 RID: 4504
		// (get) Token: 0x06005669 RID: 22121 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600566A RID: 22122 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17001198")]
		public BankManager Bank
		{
			[Token(Token = "0x6005669")]
			[Address(RVA = "0xA3F6", Offset = "0xA3F6", VA = "0xA3F6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600566A")]
			[Address(RVA = "0xA3F7", Offset = "0xA3F7", VA = "0xA3F7")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17001199 RID: 4505
		// (get) Token: 0x0600566B RID: 22123 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17001199")]
		public List<IAccountDataDecorator> AvailAccounts
		{
			[Token(Token = "0x600566B")]
			[Address(RVA = "0xA3F8", Offset = "0xA3F8", VA = "0xA3F8")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700119A RID: 4506
		// (get) Token: 0x0600566C RID: 22124 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600566D RID: 22125 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119A")]
		public IAccountDataDecorator CurrentBrowsedAccount
		{
			[Token(Token = "0x600566C")]
			[Address(RVA = "0xA3F9", Offset = "0xA3F9", VA = "0xA3F9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600566D")]
			[Address(RVA = "0xA3FA", Offset = "0xA3FA", VA = "0xA3FA")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119B RID: 4507
		// (get) Token: 0x0600566E RID: 22126 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x0600566F RID: 22127 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119B")]
		public IDictProvider Dictionaries
		{
			[Token(Token = "0x600566E")]
			[Address(RVA = "0xA3FB", Offset = "0xA3FB", VA = "0xA3FB")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600566F")]
			[Address(RVA = "0xA3FC", Offset = "0xA3FC", VA = "0xA3FC")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119C RID: 4508
		// (get) Token: 0x06005670 RID: 22128 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005671 RID: 22129 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119C")]
		public ClansModel ClansModel
		{
			[Token(Token = "0x6005670")]
			[Address(RVA = "0xA3FD", Offset = "0xA3FD", VA = "0xA3FD")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005671")]
			[Address(RVA = "0xA3FE", Offset = "0xA3FE", VA = "0xA3FE")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x1700119D RID: 4509
		// (get) Token: 0x06005672 RID: 22130 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005673 RID: 22131 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119D")]
		public BattleAccount BattleAccount
		{
			[Token(Token = "0x6005672")]
			[Address(RVA = "0xA3FF", Offset = "0xA3FF", VA = "0xA3FF")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005673")]
			[Address(RVA = "0xA400", Offset = "0xA400", VA = "0xA400")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119E RID: 4510
		// (get) Token: 0x06005674 RID: 22132 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005675 RID: 22133 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119E")]
		public ManufactureAccount ManufactureAccount
		{
			[Token(Token = "0x6005674")]
			[Address(RVA = "0xA401", Offset = "0xA401", VA = "0xA401")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005675")]
			[Address(RVA = "0xA402", Offset = "0xA402", VA = "0xA402")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x1700119F RID: 4511
		// (get) Token: 0x06005676 RID: 22134 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005677 RID: 22135 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1700119F")]
		public TradeAccount TradeAccount
		{
			[Token(Token = "0x6005676")]
			[Address(RVA = "0xA403", Offset = "0xA403", VA = "0xA403")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005677")]
			[Address(RVA = "0xA404", Offset = "0xA404", VA = "0xA404")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011A0 RID: 4512
		// (get) Token: 0x06005678 RID: 22136 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005679 RID: 22137 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011A0")]
		public ClanAccountGroup ClanAccountGroup
		{
			[Token(Token = "0x6005678")]
			[Address(RVA = "0xA405", Offset = "0xA405", VA = "0xA405")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005679")]
			[Address(RVA = "0xA406", Offset = "0xA406", VA = "0xA406")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011A1 RID: 4513
		// (get) Token: 0x0600567A RID: 22138 RVA: 0x0000F858 File Offset: 0x0000DA58
		// (set) Token: 0x0600567B RID: 22139 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011A1")]
		public int NotificationsCount
		{
			[Token(Token = "0x600567A")]
			[Address(RVA = "0xA407", Offset = "0xA407", VA = "0xA407")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x600567B")]
			[Address(RVA = "0xA408", Offset = "0xA408", VA = "0xA408")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x0600567C RID: 22140 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567C")]
		[Address(RVA = "0xA409", Offset = "0xA409", VA = "0xA409", Slot = "5")]
		public override void Dispose()
		{
		/* --- GHIDRA: Dispose ---
		void Gameplay_Accounts_Model_AccountsModel__Dispose
		               (int param1,undefined4 param2,undefined4 param3,undefined4 param4,undefined4 param5,
		               undefined4 param6,undefined4 param7)
		
		{
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a588ad == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic___ctor__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_IAccountDataDecorator__TypeInfo);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_List_PromotionsDic__TypeInfo);
		    DAT_ram_00a588ad = '\x01';
		  }
		  Unity_Services_Core_Environments_Internal_Environments__get_Current(param1,param5,0);
		  *(undefined4 *)(param1 + 0x24) = param4;
		  *(undefined4 *)(param1 + 0x20) = param3;
		  *(undefined4 *)(param1 + 0x14) = param2;
		  *(undefined4 *)(param1 + 0xc) = param6;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_IAccountDataDecorator__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_IAccountDataDecorator___ctor__);
		  *(undefined4 *)(param1 + 0x18) = uVar1;
		  uVar1 = unnamed_function_1417(System_Collections_Generic_List_PromotionsDic__TypeInfo);
		  GAFInternal_Objects_GAFBakedObjectImpl__get_isVisible
		            (uVar1,Method_System_Collections_Generic_List_PromotionsDic___ctor__);
		  *(undefined4 *)(param1 + 0x10) = uVar1;
		  return;
		}
		*/

		}

		// Token: 0x0600567D RID: 22141 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567D")]
		[Address(RVA = "0xA40A", Offset = "0xA40A", VA = "0xA40A")]
		public AccountsModel(IList<AccountOptionsDic> accountOptionsDics, IDictProvider dictionaries, ClansModel clansModel, UserData user, BankManager bank)
		{
		/* --- GHIDRA: .ctor ---
		void Gameplay_Accounts_Model_AccountsModel___ctor(int param1,undefined4 param2,undefined4 param3)
		
		{
		  int param1_00;
		  int param3_00;
		  
		  if (DAT_ram_00a588af == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic__AddRange__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_PromotionsDic__Clear__);
		    DAT_ram_00a588af = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x10);
		  param3_00 = *(int *)(param1_00 + 0xc);
		  *(undefined4 *)(param1_00 + 0xc) = 0;
		  *(int *)(param1_00 + 0x10) = *(int *)(param1_00 + 0x10) + 1;
		  if (0 < param3_00) {
		    func_ii_2064(*(undefined4 *)(param1_00 + 8),0,param3_00,0);
		    param1_00 = *(int *)(param1 + 0x10);
		  }
		  func_ii_6335(param1_00,param2,Method_System_Collections_Generic_List_PromotionsDic__AddRange__);
		  return;
		}
		*/

		}

		// Token: 0x0600567E RID: 22142 RVA: 0x0000F870 File Offset: 0x0000DA70
		[Token(Token = "0x600567E")]
		[Address(RVA = "0x1D34", Offset = "0x1D34", VA = "0x1D34")]
		private bool TryFillAccount(uint id, out IAccountDataDecorator result, params IAccountDataDecorator[] accounts)
		{
			return default(bool);
		}

		// Token: 0x0600567F RID: 22143 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600567F")]
		[Address(RVA = "0xA40B", Offset = "0xA40B", VA = "0xA40B")]
		public void SetActivePromotions(List<PromotionsDic> promotions)
		{
		/* --- GHIDRA: SetActivePromotions ---
		uint Gameplay_Accounts_Model_AccountsModel__SetActivePromotions
		               (int param1,undefined4 param2,int *param3,undefined4 param4)
		
		{
		  int iVar1;
		  uint uVar2;
		  int *local_4;
		  
		  if (DAT_ram_00a588b1 == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo);
		    DAT_ram_00a588b1 = '\x01';
		  }
		  local_4 = (int *)0x0;
		  iVar1 = func_ii_6875(*(undefined4 *)(*(int *)(param1 + 0xc) + 0x2c),param2,&local_4,0);
		  if (iVar1 == 0) {
		    *param3 = 0;
		    uVar2 = 0;
		  }
		  else {
		    if (local_4 == (int *)0x0) {
		      local_4 = (int *)0x0;
		    }
		    else if ((uint)*(byte *)(*local_4 + 0xb8) <
		             (uint)*(byte *)(Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo + 0xb8)) {
		      local_4 = (int *)0x0;
		    }
		    else if (*(int *)(*(int *)(*local_4 + 100) +
		                      (uint)*(byte *)(Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo + 0xb8
		                                     ) * 4 + -4) !=
		             Gameplay_Accounts_Model_Data_AccountOptionData_TypeInfo) {
		      local_4 = (int *)0x0;
		    }
		    *param3 = (int)local_4;
		    uVar2 = (uint)(local_4 != (int *)0x0);
		  }
		  return uVar2;
		}
		*/

		}

		// Token: 0x06005680 RID: 22144 RVA: 0x0000F888 File Offset: 0x0000DA88
		[Token(Token = "0x6005680")]
		[Address(RVA = "0x1D3E", Offset = "0x1D3E", VA = "0x1D3E")]
		public bool TryGetAccount(uint id, out IAccountDataDecorator account)
		{
		/* --- GHIDRA: TryGetAccount ---
		undefined4
		Gameplay_Accounts_Model_AccountsModel__TryGetAccount
		          (int param1,int param2,int *param3,undefined4 param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  int iVar3;
		  int param2_00;
		  
		  param2_00 = 0;
		  if (DAT_ram_00a5ad60 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountDic__get_Count__);
		    Mono_Security_ASN1__get_Item
		              (&Method_Google_Protobuf_Collections_RepeatedField_AccountDic__get_Item__);
		    DAT_ram_00a5ad60 = '\x01';
		  }
		  uVar1 = 1;
		  iVar3 = *(int *)(*(int *)(param1 + 0x6c) + 0xc);
		  if (iVar3 < 1) {
		code_r0x812da313:
		    *param3 = 0;
		    return 0;
		  }
		  iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                    (*(undefined4 *)(param1 + 0x6c),0,
		                     Method_Google_Protobuf_Collections_RepeatedField_AccountDic__get_Item__);
		  *param3 = iVar2;
		  if (*(int *)(iVar2 + 0xc) != param2) {
		    do {
		      param2_00 = param2_00 + 1;
		      if (param2_00 == iVar3) goto code_r0x812da313;
		      iVar2 = Google_Protobuf_Collections_RepeatedField_Int32Enum___get_IsReadOnly
		                        (*(undefined4 *)(param1 + 0x6c),param2_00,
		                         Method_Google_Protobuf_Collections_RepeatedField_AccountDic__get_Item__);
		      *param3 = iVar2;
		    } while (param2 != *(int *)(iVar2 + 0xc));
		    uVar1 = (uint)(param2_00 < iVar3);
		  }
		  return uVar1;
		}
		*/

			return default(bool);
		}

		// Token: 0x06005681 RID: 22145 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6005681")]
		public T GetAccount<T>(uint id) where T : IAccountDataDecorator, new()
		{
			return null;
		}

		// Token: 0x06005682 RID: 22146 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		[Token(Token = "0x6005682")]
		[Address(RVA = "0xA40C", Offset = "0xA40C", VA = "0xA40C")]
		public bool TryGetOption(uint optionId, out AccountOptionData result)
		{
			return default(bool);
		}

		// Token: 0x04002EE5 RID: 12005
		[Token(Token = "0x4002EE5")]
		[FieldOffset(Offset = "0x10")]
		public readonly List<PromotionsDic> ActivePromotions;

		// Token: 0x04002EE6 RID: 12006
		[Token(Token = "0x4002EE6")]
		[FieldOffset(Offset = "0x14")]
		public readonly IList<AccountOptionsDic> AccountOptions;

		// Token: 0x04002EE7 RID: 12007
		[Token(Token = "0x4002EE7")]
		[FieldOffset(Offset = "0x18")]
		private readonly List<IAccountDataDecorator> _accountsCache;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_NotificationsCount ---
		void Gameplay_Accounts_Model_AccountsModel__set_NotificationsCount(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  int param3;
		  
		  if (DAT_ram_00a588ac == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__Clear__);
		    DAT_ram_00a588ac = '\x01';
		  }
		  iVar1 = *(int *)(param1 + 0x18);
		  param3 = *(int *)(iVar1 + 0xc);
		  *(undefined4 *)(iVar1 + 0xc) = 0;
		  *(int *)(iVar1 + 0x10) = *(int *)(iVar1 + 0x10) + 1;
		  if (0 < param3) {
		    func_ii_2064(*(undefined4 *)(iVar1 + 8),0,param3,0);
		  }
		  *(undefined8 *)(param1 + 0x20) = 0;
		  *(undefined4 *)(param1 + 0xc) = 0;
		  Core_ExternalIncomingScriptCall_CallbackItem___Il2CppFullySharedGenericType____ctor(param1,0);
		  return;
		}
		*/


		/* --- GHIDRA: GetAccount<object> ---
		void Gameplay_Accounts_Model_AccountsModel__GetAccount_object_
		               (int param1,undefined4 param2,undefined4 param3,int param4)
		
		{
		  uint uVar1;
		  int iVar2;
		  uint *puVar3;
		  undefined4 uVar4;
		  undefined4 uVar5;
		  int *piVar6;
		  undefined1 *param3_00;
		  int param3_01;
		  uint uVar7;
		  undefined4 *puVar8;
		  int *param1_00;
		  int param1_01;
		  undefined1 local_10 [8];
		  int *local_8;
		  undefined1 *local_4;
		  
		  piVar6 = *(int **)(param4 + 0x1c);
		  if (piVar6 == (int *)0x0) {
		    Mono_Security_ASN1__get_Item(&Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Dict_IDictProvider_TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_List_IAccountDataDecorator__Add__);
		    piVar6 = *(int **)(param4 + 0x1c);
		    if (piVar6 == (int *)0x0) {
		      System_ReadOnlySpan_char___GetPinnableReference(param4);
		      piVar6 = *(int **)(param4 + 0x1c);
		    }
		  }
		  param3_01 = *(int *)(*piVar6 + 0x84);
		  uVar7 = param3_01 + 0xfU & 0xfffffff0;
		  param3_00 = local_10 + -uVar7;
		  local_8 = (int *)0x0;
		  iVar2 = func_ii_7485(param1,param2,&local_8,0);
		  piVar6 = local_8;
		  if (iVar2 == 0) {
		    puVar8 = *(undefined4 **)(*(int *)(param4 + 0x1c) + 4);
		    local_4 = param3_00;
		    (**(code **)((ulonglong)(uint)puVar8[2] * 4))(*puVar8,puVar8,0,&local_4,param3_00);
		    piVar6 = (int *)func_ii_1081(**(undefined4 **)(param4 + 0x1c),param3_00);
		    param1_00 = *(int **)(param1 + 0x20);
		    iVar2 = *param1_00;
		    local_8 = piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      uVar1 = 0;
		      do {
		        if (Core_Dict_IDictProvider_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		          goto code_r0x821eab21;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(param1_00,Core_Dict_IDictProvider_TypeInfo,2);
		code_r0x821eab21:
		    uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		    uVar1 = 0;
		    uVar5 = func_ii_7504(*(undefined4 *)(param1 + 8),0);
		    iVar2 = *piVar6;
		    if (*(ushort *)(iVar2 + 0xb6) != 0) {
		      do {
		        if (Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo ==
		            *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8)) {
		          puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xf8);
		          goto code_r0x821eabb6;
		        }
		        uVar1 = uVar1 + 1;
		      } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		    }
		    puVar3 = (uint *)func_ii_1080(piVar6,Gameplay_Accounts_Model_Data_IAccountDataDecorator_TypeInfo
		                                  ,7);
		code_r0x821eabb6:
		    (**(code **)((ulonglong)*puVar3 * 4))(piVar6,param2,uVar4,uVar5,puVar3[1]);
		    iVar2 = Method_System_Collections_Generic_List_IAccountDataDecorator__Add__;
		    param1_01 = *(int *)(param1 + 0x18);
		    *(int *)(param1_01 + 0x10) = *(int *)(param1_01 + 0x10) + 1;
		    uVar1 = *(uint *)(param1_01 + 0xc);
		    if (uVar1 < *(uint *)(*(int *)(param1_01 + 8) + 0xc)) {
		      *(uint *)(param1_01 + 0xc) = uVar1 + 1;
		      *(int **)(*(int *)(param1_01 + 8) + uVar1 * 4 + 0x10) = local_8;
		    }
		    else {
		      System_Linq_Expressions_Interpreter_LeaveExceptionHandlerInstruction__Create
		                (param1_01,local_8,*(undefined4 *)(*(int *)(*(int *)(iVar2 + 0x10) + 0x60) + 0x38));
		    }
		    piVar6 = local_8;
		    iVar2 = **(int **)(param4 + 0x1c);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    uVar4 = func_ii_2732(piVar6,iVar2,(int)param3_00 - uVar7);
		  }
		  else {
		    iVar2 = **(int **)(param4 + 0x1c);
		    if ((*(byte *)(iVar2 + 0xbd) & 1) == 0) {
		      iVar2 = func_ii_1079(iVar2);
		    }
		    uVar4 = func_ii_2732(piVar6,iVar2,param3_00);
		  }
		  unnamed_function_713(param3,uVar4,param3_01);
		  return;
		}
		*/

}
