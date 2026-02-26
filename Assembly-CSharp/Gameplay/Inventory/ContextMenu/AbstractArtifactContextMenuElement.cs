using System;
using Gameplay.Inventory.View;
using Il2CppDummyDll;
using Protocol.Dic;

namespace Gameplay.Inventory.ContextMenu
{
	// Token: 0x020006C7 RID: 1735
	[Token(Token = "0x20006C7")]
	public abstract class AbstractArtifactContextMenuElement
	{
		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060029F1 RID: 10737
		[Token(Token = "0x170007E9")]
		public abstract ArtikulMenuActionDic.Types.Actions ActionId { [Token(Token = "0x60029F1")] get; }

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060029F2 RID: 10738 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007EA")]
		public string Title
		{
			[Token(Token = "0x60029F2")]
			[Address(RVA = "0x7A97", Offset = "0x7A97", VA = "0x7A97")]
			get
			{
				return null;
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060029F3 RID: 10739 RVA: 0x00007ED8 File Offset: 0x000060D8
		[Token(Token = "0x170007EB")]
		public uint Position
		{
			[Token(Token = "0x60029F3")]
			[Address(RVA = "0x7A98", Offset = "0x7A98", VA = "0x7A98")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x060029F4 RID: 10740 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170007EC")]
		public string IconAssetId
		{
			[Token(Token = "0x60029F4")]
			[Address(RVA = "0x7A99", Offset = "0x7A99", VA = "0x7A99")]
			get
			{
				return null;
			}
		}

		// Token: 0x060029F5 RID: 10741
		[Token(Token = "0x60029F5")]
		public abstract bool Validate(IArtifactView artifactView);

		// Token: 0x060029F6 RID: 10742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F6")]
		[Address(RVA = "0x7A9A", Offset = "0x7A9A", VA = "0x7A9A", Slot = "6")]
		public virtual void Setup(IArtifactView artifactView)
		{
		}

		// Token: 0x060029F7 RID: 10743
		[Token(Token = "0x60029F7")]
		public abstract void Handle(IArtifactView artifactView);

		// Token: 0x060029F8 RID: 10744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029F8")]
		[Address(RVA = "0x7A9B", Offset = "0x7A9B", VA = "0x7A9B")]
		protected AbstractArtifactContextMenuElement()
		{
		}

		// Token: 0x0400173A RID: 5946
		[Token(Token = "0x400173A")]
		[FieldOffset(Offset = "0x8")]
		protected string _title;

		// Token: 0x0400173B RID: 5947
		[Token(Token = "0x400173B")]
		[FieldOffset(Offset = "0xC")]
		protected uint _position;

		// Token: 0x0400173C RID: 5948
		[Token(Token = "0x400173C")]
		[FieldOffset(Offset = "0x10")]
		protected string _iconAssetId;

		// Token: 0x0400173D RID: 5949
		[Token(Token = "0x400173D")]
		[FieldOffset(Offset = "0x14")]
		private ArtikulMenuActionDic _artikulMenuActionDic;

		// Token: 0x0400173E RID: 5950
		[Token(Token = "0x400173E")]
		[FieldOffset(Offset = "0x18")]
		private ArtikulTypeMenuActionDic _artikulTypeMenuActionDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IconAssetId ---
		void Gameplay_Inventory_ContextMenu_AbstractArtifactContextMenuElement__get_IconAssetId
		               (int *param1,int *param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 uVar4;
		  int *piVar5;
		  int iVar6;
		  int param1_00;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5a190 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_ArtikulMenuActionDic_Types_Actions_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Gameplay_Inventory_View_IArtifactView_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2836);
		    DAT_ram_00a5a190 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x811da2b8;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811da2b8:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xe4));
		  iVar6 = Core_Extensions_Dict_DictExt__GetUserMenuActionDic(uVar3,uVar4,0);
		  param1[5] = iVar6;
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  piVar5 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar6 = *piVar5;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    uVar1 = 0;
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0x178);
		        goto code_r0x811da389;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(piVar5,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x811da389:
		  uVar1 = 0;
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(piVar5,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  uVar4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                    (param1,*(undefined4 *)(*param1 + 0xe4));
		  iVar6 = *param2;
		  if (*(ushort *)(iVar6 + 0xb6) != 0) {
		    do {
		      if (Gameplay_Inventory_View_IArtifactView_TypeInfo ==
		          *(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar6 + 0x58) + uVar1 * 8 + 4) * 8 + iVar6 + 0xd0);
		        goto code_r0x811da42f;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar6 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param2,Gameplay_Inventory_View_IArtifactView_TypeInfo,2);
		code_r0x811da42f:
		  iVar6 = (**(code **)((ulonglong)*puVar2 * 4))(param2,puVar2[1]);
		  iVar6 = Core_Extensions_Dict_DictExt__GetArtikulMenuActionDic
		                    (uVar3,uVar4,*(undefined4 *)(*(int *)(iVar6 + 0xc) + 0xc),0);
		  param1[6] = iVar6;
		  param1_00 = param1[5];
		  if (param1_00 == 0) {
		    local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4));
		    uVar3 = func_ii_1081(Protocol_Dic_ArtikulMenuActionDic_Types_Actions_TypeInfo,&local_4);
		    uVar3 = func_ii_4419(StringLiteral_2836,uVar3,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar3,0);
		    return;
		  }
		  if (iVar6 != 0) {
		    iVar6 = Core_Extensions_Dict_ArtikulTypeMenuActionDicExt__GetIconAssetId(iVar6,0);
		    if (iVar6 != 0) goto code_r0x811da4de;
		    param1_00 = param1[5];
		  }
		  iVar6 = Core_Extensions_Dict_ArtikulMenuActionDicExt__GetIconAssetId(param1_00,0);
		code_r0x811da4de:
		  param1[2] = iVar6;
		  if ((param1[6] == 0) ||
		     (iVar6 = Core_Extensions_Dict_ArtikulTypeFilterDicExt__GetIconDisabled(param1[6],0), iVar6 == 0
		     )) {
		    iVar6 = Core_Extensions_Dict_ArtikulDicExt__GetDescription(param1[5],0);
		  }
		  param1[4] = iVar6;
		  if (param1[6] == 0) {
		    piVar5 = (int *)(param1[5] + 0x18);
		  }
		  else {
		    piVar5 = (int *)(param1[6] + 0x20);
		  }
		  param1[3] = *piVar5;
		  return;
		}
		*/

}
