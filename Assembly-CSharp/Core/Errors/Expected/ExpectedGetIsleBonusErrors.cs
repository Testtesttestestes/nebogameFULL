using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace Core.Errors.Expected
{
	// Token: 0x0200105C RID: 4188
	[Token(Token = "0x200105C")]
	public class ExpectedGetIsleBonusErrors : ExpectedDefaultError
	{
		// Token: 0x06006245 RID: 25157 RVA: 0x000125B8 File Offset: 0x000107B8
		[Token(Token = "0x6006245")]
		[Address(RVA = "0xAE6B", Offset = "0xAE6B", VA = "0xAE6B", Slot = "4")]
		public override bool Handle(int errorCode)
		{
		/* --- GHIDRA: Handle ---
		void Core_Errors_Expected_ExpectedGetIsleBonusErrors__Handle
		               (undefined4 param1,undefined4 param2,undefined4 param3,undefined4 param4)
		
		{
		  int param1_00;
		  undefined4 uVar1;
		  
		  if (DAT_ram_00a5a37c == '\0') {
		    Mono_Security_ASN1__get_Item(&UI_Windows_Alert_AlertArgs_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_GameLocalization_TypeInfo);
		    DAT_ram_00a5a37c = '\x01';
		  }
		  param1_00 = unnamed_function_1417(UI_Windows_Alert_AlertArgs_TypeInfo);
		  UI_Windows_Alert__Show(param1_00,0);
		  if (*(int *)(Core_GameLocalization_TypeInfo + 0x74) == 0) {
		    func_ii_306000(Core_GameLocalization_TypeInfo);
		  }
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(param2,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x18) = uVar1;
		  uVar1 = Core_Extensions_Dict_CultDicExt__GetTitle(param3,1,0,1,0,0,0,0);
		  *(undefined4 *)(param1_00 + 0x1c) = uVar1;
		  UI_Windows_UnityInstantiator___ctor(param1_00,0);
		  return;
		}
		*/

			return default(bool);
		}

		// Token: 0x06006246 RID: 25158 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006246")]
		[Address(RVA = "0xAE6C", Offset = "0xAE6C", VA = "0xAE6C")]
		private void ShowAlert(string titleKey, string descKey)
		{
		/* --- GHIDRA: ShowAlert ---
		void Core_Errors_Expected_ExpectedGetIsleBonusErrors__ShowAlert(int param1,undefined4 param2)
		
		{
		  int *param1_00;
		  int iVar1;
		  
		  if (DAT_ram_00a5a37d == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		              );
		    DAT_ram_00a5a37d = '\x01';
		  }
		  param1_00 = *(int **)(param1 + 8);
		  if (param1_00 != (int *)0x0) {
		    if (((uint)*(byte *)(*param1_00 + 0xb8) <
		         (uint)*(byte *)(
		                        Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                        + 0xb8)) ||
		       (*(int *)(*(int *)(*param1_00 + 100) +
		                 (uint)*(byte *)(
		                                Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                                + 0xb8) * 4 + -4) !=
		        Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo)) {
		      System_Activator__CreateInstance
		                (param1_00,
		                 Core_Errors_Expected_ExpectedGetIsleBonusErrors_ExpectedGetIsleBonusErrorsArgs_TypeInfo
		                );
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  iVar1 = param1_00[2];
		  if (iVar1 != 0) {
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xc) * 4))
		              (*(undefined4 *)(iVar1 + 0x20),*(undefined4 *)(iVar1 + 0x14));
		  }
		  return;
		}
		*/

		}

		// Token: 0x06006247 RID: 25159 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006247")]
		[Address(RVA = "0xAE6D", Offset = "0xAE6D", VA = "0xAE6D")]
		private void HandleDiamondIsleFound()
		{
		}

		// Token: 0x06006248 RID: 25160 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006248")]
		[Address(RVA = "0xAE6E", Offset = "0xAE6E", VA = "0xAE6E")]
		public ExpectedGetIsleBonusErrors()
		{
		}

		// Token: 0x0200105D RID: 4189
		[Token(Token = "0x200105D")]
		public class ExpectedGetIsleBonusErrorsArgs : IDisposable
		{
			// Token: 0x170013A7 RID: 5031
			// (get) Token: 0x06006249 RID: 25161 RVA: 0x00002052 File Offset: 0x00000252
			// (set) Token: 0x0600624A RID: 25162 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170013A7")]
			public Action OnDiamondIsleFoundCallback
			{
				[Token(Token = "0x6006249")]
				[Address(RVA = "0xAE6F", Offset = "0xAE6F", VA = "0xAE6F")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Token(Token = "0x600624A")]
				[Address(RVA = "0xAE70", Offset = "0xAE70", VA = "0xAE70")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x0600624B RID: 25163 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600624B")]
			[Address(RVA = "0xAE71", Offset = "0xAE71", VA = "0xAE71")]
			public ExpectedGetIsleBonusErrorsArgs(Action onDiamondIsleFoundCallback)
			{
			}

			// Token: 0x0600624C RID: 25164 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x600624C")]
			[Address(RVA = "0xAE72", Offset = "0xAE72", VA = "0xAE72", Slot = "4")]
			public void Dispose()
			{
			}
		}
	}
}
