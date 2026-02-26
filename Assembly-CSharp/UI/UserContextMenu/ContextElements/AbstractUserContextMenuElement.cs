using System;
using Il2CppDummyDll;
using Protocol.Dic;

namespace UI.UserContextMenu.ContextElements
{
	// Token: 0x0200012B RID: 299
	[Token(Token = "0x200012B")]
	public abstract class AbstractUserContextMenuElement
	{
		// Token: 0x1700012D RID: 301
		// (get) Token: 0x0600092F RID: 2351
		[Token(Token = "0x1700012D")]
		public abstract UserMenuActionDic.Types.Actions ActionId { [Token(Token = "0x600092F")] get; }

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x06000930 RID: 2352 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x1700012E")]
		public string Title
		{
			[Token(Token = "0x6000930")]
			[Address(RVA = "0x5CAC", Offset = "0x5CAC", VA = "0x5CAC")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00003630 File Offset: 0x00001830
		[Token(Token = "0x1700012F")]
		public uint Position
		{
			[Token(Token = "0x6000931")]
			[Address(RVA = "0x5CAD", Offset = "0x5CAD", VA = "0x5CAD")]
			get
			{
				return 0U;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000932 RID: 2354 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000130")]
		public string IconAssetId
		{
			[Token(Token = "0x6000932")]
			[Address(RVA = "0x5CAE", Offset = "0x5CAE", VA = "0x5CAE")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000933 RID: 2355
		[Token(Token = "0x6000933")]
		public abstract bool Validate(IUserMenuContext context);

		// Token: 0x06000934 RID: 2356 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000934")]
		[Address(RVA = "0x5CAF", Offset = "0x5CAF", VA = "0x5CAF", Slot = "6")]
		public virtual void Setup(IUserMenuContext context)
		{
		}

		// Token: 0x06000935 RID: 2357
		[Token(Token = "0x6000935")]
		public abstract void Handle(IUserMenuContext context);

		// Token: 0x06000936 RID: 2358 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000936")]
		[Address(RVA = "0x5CB0", Offset = "0x5CB0", VA = "0x5CB0")]
		protected AbstractUserContextMenuElement()
		{
		}

		// Token: 0x04000368 RID: 872
		[Token(Token = "0x4000368")]
		[FieldOffset(Offset = "0x8")]
		protected string _title;

		// Token: 0x04000369 RID: 873
		[Token(Token = "0x4000369")]
		[FieldOffset(Offset = "0xC")]
		protected uint _position;

		// Token: 0x0400036A RID: 874
		[Token(Token = "0x400036A")]
		[FieldOffset(Offset = "0x10")]
		protected string _iconAssetId;

		// Token: 0x0400036B RID: 875
		[Token(Token = "0x400036B")]
		[FieldOffset(Offset = "0x14")]
		private UserMenuActionDic _userMenuActionDic;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: get_IconAssetId ---
		void UI_UserContextMenu_ContextElements_AbstractUserContextMenuElement__get_IconAssetId
		               (int *param1,undefined4 param2,undefined4 param3)
		
		{
		  uint uVar1;
		  uint *puVar2;
		  undefined4 uVar3;
		  undefined4 param2_00;
		  int *param1_00;
		  int iVar4;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a5b8c4 == '\0') {
		    Mono_Security_ASN1__get_Item(&Protocol_Dic_UserMenuActionDic_Types_Actions_TypeInfo);
		    Mono_Security_ASN1__get_Item(&OKG_Logs_Debug_TypeInfo);
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_IGame_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_2838);
		    DAT_ram_00a5b8c4 = '\x01';
		  }
		  if (DAT_ram_00a6456f == '\0') {
		    Mono_Security_ASN1__get_Item(&Core_Gameplay_Game_TypeInfo);
		    DAT_ram_00a6456f = '\x01';
		  }
		  uVar1 = 0;
		  param1_00 = (int *)**(undefined4 **)(Core_Gameplay_Game_TypeInfo + 0x5c);
		  iVar4 = *param1_00;
		  if (*(ushort *)(iVar4 + 0xb6) != 0) {
		    do {
		      if (Core_Gameplay_IGame_TypeInfo == *(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8)) {
		        puVar2 = (uint *)(*(int *)(*(int *)(iVar4 + 0x58) + uVar1 * 8 + 4) * 8 + iVar4 + 0x178);
		        goto code_r0x8138e1ef;
		      }
		      uVar1 = uVar1 + 1;
		    } while (*(ushort *)(iVar4 + 0xb6) != uVar1);
		  }
		  puVar2 = (uint *)func_ii_1080(param1_00,Core_Gameplay_IGame_TypeInfo,0x17);
		code_r0x8138e1ef:
		  uVar3 = (**(code **)((ulonglong)*puVar2 * 4))(param1_00,puVar2[1]);
		  uVar3 = Newtonsoft_Json_Converters_XmlDocumentTypeWrapper__get_System(uVar3,0);
		  param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4));
		  iVar4 = Core_Extensions_Dict_DictExt__GetRequirementDic(uVar3,param2_00,0);
		  param1[5] = iVar4;
		  if (iVar4 == 0) {
		    local_4 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe0) * 4))
		                        (param1,*(undefined4 *)(*param1 + 0xe4));
		    uVar3 = func_ii_1081(Protocol_Dic_UserMenuActionDic_Types_Actions_TypeInfo,&local_4);
		    uVar3 = func_ii_4419(StringLiteral_2838,uVar3,0);
		    if (*(int *)(OKG_Logs_Debug_TypeInfo + 0x74) == 0) {
		      func_ii_306000(OKG_Logs_Debug_TypeInfo);
		    }
		    func_ii_7830(uVar3,0);
		  }
		  else {
		    iVar4 = Core_Extensions_Dict_UserMenuActionDicExt__GetIconAssetId(iVar4,0);
		    param1[2] = iVar4;
		    iVar4 = Core_Extensions_Dict_UserBuildingViewsDicExt__GetIsleViewUiAssetId(param1[5],0);
		    param1[4] = iVar4;
		    param1[3] = *(int *)(param1[5] + 0x18);
		  }
		  return;
		}
		*/

}
