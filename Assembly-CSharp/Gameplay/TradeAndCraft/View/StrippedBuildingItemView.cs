using System;
using Core.Data;
using Gameplay.World.Model;
using Il2CppDummyDll;
using UI.Windows.Buildings;

namespace Gameplay.TradeAndCraft.View
{
	// Token: 0x02000497 RID: 1175
	[Token(Token = "0x2000497")]
	public class StrippedBuildingItemView : BaseBuildingItemView
	{
		// Token: 0x06001BCC RID: 7116 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCC")]
		[Address(RVA = "0x6D4B", Offset = "0x6D4B", VA = "0x6D4B", Slot = "7")]
		protected override void HandleActionButton(UserData ownerUserData, UserData loggedUser)
		{
		/* --- GHIDRA: HandleActionButton ---
		void Gameplay_TradeAndCraft_View_StrippedBuildingItemView__HandleActionButton
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  
		  if (DAT_ram_00a584c3 == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&
		               Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		              );
		    DAT_ram_00a584c3 = '\x01';
		  }
		  *(undefined4 *)(param1 + 0x3c) = param2;
		  uVar2 = *(undefined4 *)(param1 + 0x24);
		  uVar1 = Newtonsoft_Json_Converters_XDeclarationWrapper__get_Encoding(param2,0);
		  UI_Elements_Counters_CounterAutoHide___ctor(uVar2,uVar1,0);
		  uVar2 = *(undefined4 *)(param1 + 0x28);
		  iVar3 = **(int **)(param1 + 0x3c);
		  uVar1 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0x110) * 4))
		                    (*(int **)(param1 + 0x3c),*(undefined4 *)(iVar3 + 0x114));
		  Core_Extensions_Dict_CultDicExt__GetIcon64AssetId
		            (uVar2,uVar1,
		             Method_AssetContent_Loaders_AbstractGameGraphicLoader_RawImage__Texture2D__set_AssetId__
		            );
		  return;
		}
		*/

		}

		// Token: 0x06001BCD RID: 7117 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCD")]
		[Address(RVA = "0x6D4C", Offset = "0x6D4C", VA = "0x6D4C", Slot = "6")]
		public override void UpdateView(BaseBuildingData userBuildingData)
		{
		}

		// Token: 0x06001BCE RID: 7118 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6001BCE")]
		[Address(RVA = "0x6D4D", Offset = "0x6D4D", VA = "0x6D4D")]
		public StrippedBuildingItemView()
		{
		/* --- GHIDRA: .ctor ---
		undefined4
		Gameplay_TradeAndCraft_View_StrippedBuildingItemView___ctor(undefined4 param1,undefined4 param2)
		
		{
		  if (DAT_ram_00a584c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&StringLiteral_12677);
		    DAT_ram_00a584c4 = '\x01';
		  }
		  return StringLiteral_12677;
		}
		*/

		}
	}
}
