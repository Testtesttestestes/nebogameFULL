using System;
using Il2CppDummyDll;
using Protocol.SmallGames;
using UI.Rewards;
using UnityEngine;

namespace Gameplay.SmallGames.View.DailyRewards
{
	// Token: 0x0200052F RID: 1327
	[Token(Token = "0x200052F")]
	public class DoubleRewardView : SingleRewardView
	{
		// Token: 0x06001F95 RID: 8085 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F95")]
		[Address(RVA = "0x70FA", Offset = "0x70FA", VA = "0x70FA", Slot = "5")]
		public override void Init(ProtoRegisterVisitAns.Types.DailyRewards data, string title, SingleRewardView.State state)
		{
		/* --- GHIDRA: Init ---
		void Gameplay_SmallGames_View_DailyRewards_DoubleRewardView__Init
		               (int param1,int param2,undefined4 param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param2_00;
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a5829e == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Protocol_Common_RewardInfo___TypeInfo);
		    DAT_ram_00a5829e = '\x01';
		  }
		  param1_00 = *(undefined4 *)(param1 + 0x2c);
		  if (*(int *)(param2 + 0x10) != 0) {
		    iVar1 = Mono_Security_ASN1Convert__ToOid(Protocol_Common_RewardInfo___TypeInfo,1);
		    *(undefined4 *)(iVar1 + 0x10) = *(undefined4 *)(param2 + 0x10);
		    if (*(int *)(Core_Extensions_Dict_RewardInfoExt_TypeInfo + 0x74) == 0) {
		      func_ii_306000(Core_Extensions_Dict_RewardInfoExt_TypeInfo);
		    }
		    param2_00 = Core_Extensions_Dict_RewardInfoExt__GetGroupIndex(iVar1,0);
		    UI_Rewards_AbstractRewardsRender__get_Rewards(param1_00,param2_00,0);
		    iVar1 = **(int **)(param1 + 0x2c);
		    (**(code **)((ulonglong)*(uint *)(iVar1 + 0xf0) * 4))
		              (*(int **)(param1 + 0x2c),*(undefined4 *)(iVar1 + 0xf4));
		    return;
		  }
		  UI_Rewards_AbstractRewardsRender__get_Rewards(param1_00,0,0);
		  return;
		}
		*/

		}

		// Token: 0x06001F96 RID: 8086 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F96")]
		[Address(RVA = "0x70FB", Offset = "0x70FB", VA = "0x70FB")]
		public void InitSecondArtikul(ProtoRegisterVisitAns.Types.DailyRewards data, SingleRewardView.State state)
		{
		}

		// Token: 0x06001F97 RID: 8087 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001F97")]
		[Address(RVA = "0x70FC", Offset = "0x70FC", VA = "0x70FC")]
		public DoubleRewardView()
		{
		}

		// Token: 0x04001149 RID: 4425
		[Token(Token = "0x4001149")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		protected RewardsRender _secondArtikulRender;
	}
}
