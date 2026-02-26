using System;
using Il2CppDummyDll;
using Protocol.Common;

namespace Gameplay.Cave
{
	// Token: 0x02000B2C RID: 2860
	[Token(Token = "0x2000B2C")]
	public static class RewardBehaviourManager
	{
		// Token: 0x0600458F RID: 17807 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x600458F")]
		[Address(RVA = "0x9433", Offset = "0x9433", VA = "0x9433")]
		public static CaveModel.RewardInCave GetReward(RewardInfo rewardInfo)
		{
		/* --- GHIDRA: GetReward ---
		void Gameplay_Cave_RewardBehaviourManager__GetReward(undefined4 param1)
		
		{
		  int *piVar1;
		  int iVar2;
		  undefined4 uVar3;
		  int iVar4;
		  
		  if (DAT_ram_00a5796b == '\0') {
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_BaseRewardBehaviour___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_ExpRewardBehaviour_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_RatingsRewardBehaviour_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_ResourceRewardBehaviour_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Cave_RewardBehaviourManager_TypeInfo);
		    DAT_ram_00a5796b = '\x01';
		  }
		  piVar1 = (int *)Mono_Security_ASN1Convert__ToOid(Gameplay_Cave_BaseRewardBehaviour___TypeInfo,3);
		  iVar2 = unnamed_function_1417(Gameplay_Cave_ResourceRewardBehaviour_TypeInfo);
		  if (DAT_ram_00a57971 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_RewardTypes___TypeInfo);
		    Mono_Security_ASN1__get_Item
		              (&
		               Field__PrivateImplementationDetails__BB1422677D88C4F2FC4F5B2F17C74AE4CEBAD355ECB6CC048BB428ABBA9EB4E3
		              );
		    DAT_ram_00a57971 = '\x01';
		  }
		  uVar3 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_RewardTypes___TypeInfo,5);
		  System_Runtime_CompilerServices_RuntimeHelpers__InitializeArray
		            (uVar3,
		             Field__PrivateImplementationDetails__BB1422677D88C4F2FC4F5B2F17C74AE4CEBAD355ECB6CC048BB428ABBA9EB4E3
		             ,0);
		  *(undefined4 *)(iVar2 + 8) = uVar3;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 == 0) {
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  piVar1[4] = iVar2;
		  iVar2 = unnamed_function_1417(Gameplay_Cave_RatingsRewardBehaviour_TypeInfo);
		  if (DAT_ram_00a5796f == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Consts_RewardTypes___TypeInfo);
		    DAT_ram_00a5796f = '\x01';
		  }
		  iVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_RewardTypes___TypeInfo,1);
		  *(undefined4 *)(iVar4 + 0x10) = 0x14;
		  *(int *)(iVar2 + 8) = iVar4;
		  iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		  if (iVar4 != 0) {
		    piVar1[5] = iVar2;
		    iVar2 = unnamed_function_1417(Gameplay_Cave_ExpRewardBehaviour_TypeInfo);
		    if (DAT_ram_00a5796d == '\0') {
		      Mono_Security_ASN1__get_Item(&Protocol_Consts_RewardTypes___TypeInfo);
		      DAT_ram_00a5796d = '\x01';
		    }
		    iVar4 = Mono_Security_ASN1Convert__ToOid(Protocol_Consts_RewardTypes___TypeInfo,1);
		    *(undefined4 *)(iVar4 + 0x10) = 7;
		    *(int *)(iVar2 + 8) = iVar4;
		    iVar4 = func_ii_1082(iVar2,*(undefined4 *)(*piVar1 + 0x20));
		    if (iVar4 != 0) {
		      piVar1[6] = iVar2;
		      **(int **)(Gameplay_Cave_RewardBehaviourManager_TypeInfo + 0x5c) = (int)piVar1;
		      return;
		    }
		    uVar3 = func_ii_1083();
		    func_ii_1050(uVar3,0);
		    do {
		      halt_trap();
		    } while( true );
		  }
		  uVar3 = func_ii_1083();
		  func_ii_1050(uVar3,0);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/

			return null;
		}

		// Token: 0x04002609 RID: 9737
		[Token(Token = "0x4002609")]
		[FieldOffset(Offset = "0x0")]
		private static BaseRewardBehaviour[] _behavioursList;
	}
}
