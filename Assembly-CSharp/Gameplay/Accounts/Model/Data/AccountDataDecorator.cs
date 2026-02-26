using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Core.Data.Accounts;
using Il2CppDummyDll;
using Protocol.Common;
using Protocol.Dic;
using Utils;

namespace Gameplay.Accounts.Model.Data
{
	// Token: 0x02000DDA RID: 3546
	[Token(Token = "0x2000DDA")]
	public abstract class AccountDataDecorator : IAccountDataDecorator, IAccountData
	{
		// Token: 0x170011A2 RID: 4514
		// (get) Token: 0x06005683 RID: 22147 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005684 RID: 22148 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011A2")]
		public AccountDic AccountDic
		{
			[Token(Token = "0x6005683")]
			[Address(RVA = "0xA40D", Offset = "0xA40D", VA = "0xA40D", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005684")]
			[Address(RVA = "0xA40E", Offset = "0xA40E", VA = "0xA40E")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011A3 RID: 4515
		// (get) Token: 0x06005685 RID: 22149 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005686 RID: 22150 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011A3")]
		public virtual IAccountData Account
		{
			[Token(Token = "0x6005685")]
			[Address(RVA = "0xA40F", Offset = "0xA40F", VA = "0xA40F", Slot = "16")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005686")]
			[Address(RVA = "0xA410", Offset = "0xA410", VA = "0xA410", Slot = "17")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011A4 RID: 4516
		// (get) Token: 0x06005687 RID: 22151 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011A4")]
		public List<AccountOptionData> Options
		{
			[Token(Token = "0x6005687")]
			[Address(RVA = "0xA411", Offset = "0xA411", VA = "0xA411", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x170011A5 RID: 4517
		// (get) Token: 0x06005688 RID: 22152 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06005689 RID: 22153 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170011A5")]
		public OptionStickerDic StickerDic
		{
			[Token(Token = "0x6005688")]
			[Address(RVA = "0xA412", Offset = "0xA412", VA = "0xA412", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005689")]
			[Address(RVA = "0xA413", Offset = "0xA413", VA = "0xA413", Slot = "10")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170011A6 RID: 4518
		// (get) Token: 0x0600568A RID: 22154 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011A6")]
		public AccountInfo AccountInfo
		{
			[Token(Token = "0x600568A")]
			[Address(RVA = "0xA414", Offset = "0xA414", VA = "0xA414", Slot = "13")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011A7 RID: 4519
		// (get) Token: 0x0600568B RID: 22155 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170011A7")]
		public BackTime BackTime
		{
			[Token(Token = "0x600568B")]
			[Address(RVA = "0xA415", Offset = "0xA415", VA = "0xA415", Slot = "14")]
			get
			{
				return null;
			}
		}

		// Token: 0x170011A8 RID: 4520
		// (get) Token: 0x0600568C RID: 22156 RVA: 0x0000F8B8 File Offset: 0x0000DAB8
		[Token(Token = "0x170011A8")]
		public bool IsExpired
		{
			[Token(Token = "0x600568C")]
			[Address(RVA = "0xA416", Offset = "0xA416", VA = "0xA416", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170011A9 RID: 4521
		// (get) Token: 0x0600568D RID: 22157
		[Token(Token = "0x170011A9")]
		public abstract string Title { [Token(Token = "0x600568D")] get; }

		// Token: 0x0600568E RID: 22158
		[Token(Token = "0x600568E")]
		public abstract void Init(uint id, Dictionaries dicts, IAccountRepository accountRepository);

		// Token: 0x0600568F RID: 22159 RVA: 0x0000F8D0 File Offset: 0x0000DAD0
		[Token(Token = "0x600568F")]
		[Address(RVA = "0xA417", Offset = "0xA417", VA = "0xA417", Slot = "20")]
		public virtual bool TryGetNested(out List<IAccountDataDecorator> accounts)
		{
		/* --- GHIDRA: TryGetNested ---
		uint Gameplay_Accounts_Model_Data_AccountDataDecorator__TryGetNested
		               (undefined4 param1,uint param2,uint param3,uint param4,undefined4 param5)
		
		{
		  if ((param3 != 0) && (param4 != 0)) {
		    return (uint)(param2 <= param4 && param3 <= param2);
		  }
		  if (param3 != 0) {
		    return (uint)(param3 <= param2);
		  }
		  if (param4 != 0) {
		    return (uint)(param2 <= param4);
		  }
		  return (uint)(param2 == 0);
		}
		*/

			return default(bool);
		}

		// Token: 0x06005690 RID: 22160 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		[Token(Token = "0x6005690")]
		[Address(RVA = "0xA418", Offset = "0xA418", VA = "0xA418")]
		public bool CheckLevel(uint value, uint lowerBound, uint upperBound)
		{
			return default(bool);
		}

		// Token: 0x06005691 RID: 22161 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005691")]
		[Address(RVA = "0xA419", Offset = "0xA419", VA = "0xA419")]
		protected AccountDataDecorator()
		{
		}
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: set_StickerDic ---
		undefined4
		Gameplay_Accounts_Model_Data_AccountDataDecorator__set_StickerDic(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a588b2 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b2 = '\x01';
		  }
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x144));
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(iVar4 + *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x80f3ac04;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,0);
		code_r0x80f3ac04:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_AccountInfo ---
		undefined4
		Gameplay_Accounts_Model_Data_AccountDataDecorator__get_AccountInfo(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int *param1_00;
		  uint *puVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a588b3 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b3 = '\x01';
		  }
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x144));
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8))
		      {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 200);
		        goto code_r0x80f3acbc;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,1);
		code_r0x80f3acbc:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  return uVar3;
		}
		*/


		/* --- GHIDRA: get_BackTime ---
		undefined4
		Gameplay_Accounts_Model_Data_AccountDataDecorator__get_BackTime(int *param1,undefined4 param2)
		
		{
		  uint uVar1;
		  int iVar2;
		  int *param1_00;
		  uint *puVar3;
		  undefined4 uVar4;
		  
		  if (DAT_ram_00a588b4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Data_Accounts_IAccountData_TypeInfo);
		    DAT_ram_00a588b4 = '\x01';
		  }
		  iVar2 = (**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0x144));
		  if (iVar2 == 0) {
		    return 1;
		  }
		  param1_00 = (int *)(**(code **)((ulonglong)*(uint *)(*param1 + 0x140) * 4))
		                               (param1,*(undefined4 *)(*param1 + 0x144));
		  uVar1 = 0;
		  iVar2 = *param1_00;
		  if (*(ushort *)(iVar2 + 0xb6) != 0) {
		    do {
		      if (Core_Data_Accounts_IAccountData_TypeInfo == *(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8))
		      {
		        puVar3 = (uint *)(*(int *)(*(int *)(iVar2 + 0x58) + uVar1 * 8 + 4) * 8 + iVar2 + 0xd0);
		        goto code_r0x80f3ad91;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar2 + 0xb6) != uVar1);
		  }
		  puVar3 = (uint *)func_ii_1080(param1_00,Core_Data_Accounts_IAccountData_TypeInfo,2);
		code_r0x80f3ad91:
		  uVar4 = (**(code **)((ulonglong)*puVar3 * 4))(param1_00,puVar3[1]);
		  return uVar4;
		}
		*/


		/* --- GHIDRA: get_IsExpired ---
		undefined4
		Gameplay_Accounts_Model_Data_AccountDataDecorator__get_IsExpired
		          (undefined4 param1,undefined4 *param2,undefined4 param3)
		
		{
		  *param2 = 0;
		  return 0;
		}
		*/

}
