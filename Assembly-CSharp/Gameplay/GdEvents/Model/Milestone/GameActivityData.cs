using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.GdEvents.Model.Milestone
{
	// Token: 0x02000756 RID: 1878
	[Token(Token = "0x2000756")]
	public class GameActivityData
	{
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06002CCC RID: 11468 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170008A3")]
		public string Uri
		{
			[Token(Token = "0x6002CCC")]
			[Address(RVA = "0x7D52", Offset = "0x7D52", VA = "0x7D52")]
			get
			{
				return null;
			}
		}

		// Token: 0x06002CCD RID: 11469 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002CCD")]
		[Address(RVA = "0x7D53", Offset = "0x7D53", VA = "0x7D53")]
		public GameActivityData(GameActivityDic dict, GameActivityDic.Types.URI activity)
		{
		/* --- GHIDRA: .ctor ---
		undefined4 Gameplay_GdEvents_Model_Milestone_GameActivityData___ctor(int param1,undefined4 param2)
		
		{
		  int *param2_00;
		  int iVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a5a2de == '\0') {
		    Mono_Security_ASN1__get_Item(&object___TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_28692);
		    Mono_Security_ASN1__get_Item(&StringLiteral_6530);
		    Mono_Security_ASN1__get_Item(&StringLiteral_19431);
		    DAT_ram_00a5a2de = '\x01';
		  }
		  param2_00 = (int *)Mono_Security_ASN1Convert__ToOid(object___TypeInfo,4);
		  if (StringLiteral_6530 == 0) {
		    iVar3 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(StringLiteral_6530,*(undefined4 *)(*param2_00 + 0x20));
		    iVar3 = StringLiteral_6530;
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[4] = iVar3;
		  iVar3 = *(int *)(param1 + 8);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[5] = iVar3;
		  if (StringLiteral_19431 == 0) {
		    iVar3 = 0;
		  }
		  else {
		    iVar1 = func_ii_1082(StringLiteral_19431,*(undefined4 *)(*param2_00 + 0x20));
		    iVar3 = StringLiteral_19431;
		    if (iVar1 == 0) {
		      uVar2 = func_ii_1083();
		      func_ii_1050(uVar2,0);
		      do {
		        halt_trap();
		      } while( true );
		    }
		  }
		  param2_00[6] = iVar3;
		  iVar3 = *(int *)(param1 + 0xc);
		  if ((iVar3 != 0) && (iVar1 = func_ii_1082(iVar3,*(undefined4 *)(*param2_00 + 0x20)), iVar1 == 0))
		  {
		    uVar2 = func_ii_1083();
		    func_ii_1050(uVar2,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  param2_00[7] = iVar3;
		  uVar2 = UnityEngine_InputSystem_Utilities_TypeHelpers__GetNiceTypeName
		                    (StringLiteral_28692,param2_00,0);
		  return uVar2;
		}
		*/

		}

		// Token: 0x06002CCE RID: 11470 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6002CCE")]
		[Address(RVA = "0x7D54", Offset = "0x7D54", VA = "0x7D54", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x0400189D RID: 6301
		[Token(Token = "0x400189D")]
		[FieldOffset(Offset = "0x8")]
		public readonly GameActivityDic Dict;

		// Token: 0x0400189E RID: 6302
		[Token(Token = "0x400189E")]
		[FieldOffset(Offset = "0xC")]
		private GameActivityDic.Types.URI _activity;
	}
}
