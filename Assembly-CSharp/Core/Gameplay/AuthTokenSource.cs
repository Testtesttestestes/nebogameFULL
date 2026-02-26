using System;
using Core.Gameplay.Tokens;
using Cysharp.Threading.Tasks;
using Il2CppDummyDll;

namespace Core.Gameplay
{
	// Token: 0x02001119 RID: 4377
	[Token(Token = "0x2001119")]
	public class AuthTokenSource : IAuthTokenSource
	{
		// Token: 0x06006699 RID: 26265 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6006699")]
		[Address(RVA = "0xB21D", Offset = "0xB21D", VA = "0xB21D")]
		public AuthTokenSource(ITokenProvider provider)
		{
		/* --- GHIDRA: .ctor ---
		void Core_Gameplay_AuthTokenSource___ctor(undefined8 *param1,int param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  int *param1_00;
		  int iVar3;
		  undefined8 local_c;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a916 == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Tokens_ITokenProvider_TypeInfo);
		    DAT_ram_00a5a916 = '\x01';
		  }
		  param1_00 = *(int **)(param2 + 8);
		  iVar3 = *param1_00;
		  if (*(ushort *)(iVar3 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_Tokens_ITokenProvider_TypeInfo ==
		          *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(iVar3 + *(int *)(*(int *)(iVar3 + 0x58) + uVar1 * 8 + 4) * 8 + 0xc0);
		        goto code_r0x81290643;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar3 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_Tokens_ITokenProvider_TypeInfo,0);
		code_r0x81290643:
		  (**(code **)((ulonglong)*puVar2 * 4))(&local_c,param1_00,puVar2[1]);
		  *(undefined4 *)(param1 + 1) = local_4;
		  *param1 = local_c;
		  return;
		}
		*/

		}

		// Token: 0x0600669A RID: 26266 RVA: 0x00013740 File Offset: 0x00011940
		[Token(Token = "0x600669A")]
		[Address(RVA = "0xB21E", Offset = "0xB21E", VA = "0xB21E", Slot = "4")]
		public UniTask<string> GetToken()
		{
		/* --- GHIDRA: GetToken ---
		void Core_Gameplay_AuthTokenSource__GetToken(int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  undefined4 param2_00;
		  int param1_00;
		  int iVar2;
		  int param1_01;
		  
		  if (DAT_ram_00a5a917 == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_IAuthTokenSource__TypeInfo);
		    DAT_ram_00a5a917 = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 8);
		  while( true ) {
		    iVar2 = 0;
		    param1_01 = UnityEngine_UI_Image__set_sprite(param1_00,param2,0);
		    param2_00 = System_Action_IAuthTokenSource__TypeInfo;
		    if ((param1_01 != 0) &&
		       (iVar2 = func_ii_1082(param1_01,System_Action_IAuthTokenSource__TypeInfo), iVar2 == 0))
		    break;
		    iVar2 = func_ii_4329(param1 + 8,iVar2,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,param2_00);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return default(UniTask<string>);
		}

		// Token: 0x040036D7 RID: 14039
		[Token(Token = "0x40036D7")]
		[FieldOffset(Offset = "0x8")]
		private ITokenProvider _provider;
	}
}
