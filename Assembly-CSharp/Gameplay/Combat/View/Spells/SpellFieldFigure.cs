using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Gameplay.Combat.Model;
using Gameplay.Input;
using Il2CppDummyDll;
using Protocol.Common;
using UnityEngine;

namespace Gameplay.Combat.View.Spells
{
	// Token: 0x02000945 RID: 2373
	[Token(Token = "0x2000945")]
	[RequireComponent(typeof(Collider2D))]
	public class SpellFieldFigure : MonoBehaviour, IInputReleaseHandler
	{
		// Token: 0x1400017D RID: 381
		// (add) Token: 0x0600381F RID: 14367 RVA: 0x00002050 File Offset: 0x00000250
		// (remove) Token: 0x06003820 RID: 14368 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x1400017D")]
		public event Action OnPointerUp
		{
			[Token(Token = "0x600381F")]
			[Address(RVA = "0x87D6", Offset = "0x87D6", VA = "0x87D6")]
			[CompilerGenerated]
			add
			{
			}
			[Token(Token = "0x6003820")]
			[Address(RVA = "0x87D7", Offset = "0x87D7", VA = "0x87D7")]
			[CompilerGenerated]
			remove
			{
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B10")]
		public Color[] TexturePixel
		{
			[Token(Token = "0x6003821")]
			[Address(RVA = "0x87D8", Offset = "0x87D8", VA = "0x87D8")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06003822 RID: 14370 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x17000B11")]
		public Color[] CenterTexturePixels
		{
			[Token(Token = "0x6003822")]
			[Address(RVA = "0x87D9", Offset = "0x87D9", VA = "0x87D9")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x00002052 File Offset: 0x00000252
		// (set) Token: 0x06003824 RID: 14372 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000B12")]
		public CombatSpellData Spell
		{
			[Token(Token = "0x6003823")]
			[Address(RVA = "0x87DA", Offset = "0x87DA", VA = "0x87DA")]
			get
			{
				return null;
			}
			[Token(Token = "0x6003824")]
			[Address(RVA = "0x87DB", Offset = "0x87DB", VA = "0x87DB")]
			set
			{
			}
		}

		// Token: 0x06003825 RID: 14373 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003825")]
		[Address(RVA = "0x87DC", Offset = "0x87DC", VA = "0x87DC")]
		private void HandleSpellChanged()
		{
		/* --- GHIDRA: HandleSpellChanged ---
		undefined4
		Gameplay_Combat_View_Spells_SpellFieldFigure__HandleSpellChanged
		          (int *param1,int param2,undefined4 param3)
		
		{
		  undefined4 uVar1;
		  undefined4 uVar2;
		  int iVar3;
		  undefined8 local_40;
		  undefined8 local_38;
		  undefined8 local_30;
		  undefined8 local_28;
		  undefined8 local_1c;
		  undefined8 local_14;
		  undefined4 local_c;
		  undefined4 local_8;
		  undefined4 local_4;
		  
		  if (DAT_ram_00a566eb == '\0') {
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_Dictionary_uint__Sprite__Add__);
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Sprite__TryGetValue__);
		    Mono_Security_ASN1__get_Item(&Method_System_Linq_Enumerable_ToList_Point___);
		    Mono_Security_ASN1__get_Item(&UnityEngine_Texture2D_TypeInfo);
		    Mono_Security_ASN1__get_Item(&StringLiteral_14568);
		    DAT_ram_00a566eb = '\x01';
		  }
		  local_4 = 0;
		  iVar3 = param1[9];
		  uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		  iVar3 = UnityEngine_TextCore_LowLevel_LigatureSubstitutionRecord__get_componentGlyphIDs
		                    (iVar3,uVar1,&local_4,
		                     Method_System_Collections_Generic_Dictionary_uint__Sprite__TryGetValue__);
		  if (iVar3 == 0) {
		    uVar1 = unnamed_function_1417(UnityEngine_Texture2D_TypeInfo);
		    UnityEngine_Sprite__get_textureRect(uVar1,0x3c8,0x3c8,0);
		    local_14 = 0x4472000044720000;
		    local_30 = 0x4472000044720000;
		    local_1c = 0;
		    local_28 = 0x3f0000003f000000;
		    local_38 = 0;
		    local_40 = 0x3f0000003f000000;
		    local_8 = uVar1;
		    uVar1 = UnityEngine_Sprite__Create(uVar1,&local_38,&local_40,1.0,0);
		    local_4 = uVar1;
		    local_c = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		    uVar2 = Protocol_Combat_ProtoPlayerActionEvt___ctor(&local_c,0);
		    uVar2 = Mono_Security_X509_X509Crl_X509CrlEntry___ctor(StringLiteral_14568,uVar2,0);
		    UnityEngine_Texture2D___ctor(uVar1,uVar2,0);
		    uVar1 = System_Linq_Enumerable__Select_object__object_
		                      (*(undefined4 *)(*(int *)(param2 + 0xc) + 0x20),
		                       Method_System_Linq_Enumerable_ToList_Point___);
		    (**(code **)((ulonglong)*(uint *)(*param1 + 0xf0) * 4))
		              (param1,uVar1,&local_8,*(undefined4 *)(*param1 + 0xf4));
		    UnityEngine_Texture2D__SetPixels(local_8,0);
		    iVar3 = param1[9];
		    uVar1 = UnityEngine_AndroidJavaObject___GetRawObject(param2,0);
		    System_Collections_Generic_List_LigatureSubstitutionRecord____ctor
		              (iVar3,uVar1,local_4,Method_System_Collections_Generic_Dictionary_uint__Sprite__Add__)
		    ;
		  }
		  return local_4;
		}
		*/

		}

		// Token: 0x06003826 RID: 14374 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6003826")]
		[Address(RVA = "0x87DD", Offset = "0x87DD", VA = "0x87DD", Slot = "5")]
		protected virtual Sprite GetSprite(CombatSpellData spell)
		{
		/* --- GHIDRA: GetSprite ---
		void Gameplay_Combat_View_Spells_SpellFieldFigure__GetSprite
		               (int param1,int param2,undefined4 *param3,undefined4 param4)
		
		{
		  int iVar1;
		  undefined4 param4_00;
		  undefined4 param5;
		  int iVar2;
		  int iVar3;
		  int iVar4;
		  int iVar5;
		  
		  iVar1 = 0;
		  if (DAT_ram_00a566ec == '\0') {
		    Mono_Security_ASN1__get_Item(&UnityEngine_Color___TypeInfo);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Point__get_Count__);
		    Mono_Security_ASN1__get_Item(&Method_System_Collections_Generic_List_Point__get_Item__);
		    DAT_ram_00a566ec = '\x01';
		  }
		  iVar2 = *(int *)*param3;
		  iVar2 = (**(code **)((ulonglong)*(uint *)(iVar2 + 0xe0) * 4))
		                    ((int *)*param3,*(undefined4 *)(iVar2 + 0xe4));
		  iVar3 = *(int *)*param3;
		  iVar3 = (**(code **)((ulonglong)*(uint *)(iVar3 + 0xf0) * 4))
		                    ((int *)*param3,*(undefined4 *)(iVar3 + 0xf4));
		  iVar2 = Mono_Security_ASN1Convert__ToOid(UnityEngine_Color___TypeInfo,iVar2 * iVar3);
		  if (0 < *(int *)(iVar2 + 0xc)) {
		    do {
		      iVar3 = iVar2 + iVar1 * 0x10;
		      *(undefined8 *)(iVar3 + 0x18) = 0;
		      *(undefined8 *)(iVar3 + 0x10) = 0;
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(iVar2 + 0xc));
		  }
		  UnityEngine_Texture2D__GetPixels(*param3,iVar2,0);
		  if (0 < *(int *)(param2 + 0xc)) {
		    iVar1 = 0;
		    do {
		      iVar2 = System_Linq_Enumerable__ToList_object_
		                        (param2,iVar1,Method_System_Collections_Generic_List_Point__get_Item__);
		      iVar3 = *(int *)(iVar2 + 0x10);
		      iVar2 = *(int *)(iVar2 + 0xc);
		      if (iVar2 == 0 && iVar3 == 0) {
		        iVar5 = *(int *)(param1 + 0x2c);
		        if (iVar5 == 0) {
		          iVar5 = UnityEngine_Texture2D__GetPixels(*(undefined4 *)(param1 + 0x10),0);
		          *(int *)(param1 + 0x2c) = iVar5;
		        }
		        iVar4 = **(int **)(param1 + 0x10);
		        param4_00 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xe0) * 4))
		                              (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xe4));
		        iVar4 = **(int **)(param1 + 0x10);
		        param5 = (**(code **)((ulonglong)*(uint *)(iVar4 + 0xf0) * 4))
		                           (*(int **)(param1 + 0x10),*(undefined4 *)(iVar4 + 0xf4));
		      }
		      else {
		        iVar5 = **(int **)(param1 + 0x14);
		        param4_00 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xe0) * 4))
		                              (*(int **)(param1 + 0x14),*(undefined4 *)(iVar5 + 0xe4));
		        iVar5 = **(int **)(param1 + 0x14);
		        param5 = (**(code **)((ulonglong)*(uint *)(iVar5 + 0xf0) * 4))
		                           (*(int **)(param1 + 0x14),*(undefined4 *)(iVar5 + 0xf4));
		        iVar5 = *(int *)(param1 + 0x28);
		        if (iVar5 == 0) {
		          iVar5 = UnityEngine_Texture2D__GetPixels(*(undefined4 *)(param1 + 0x14),0);
		          *(int *)(param1 + 0x28) = iVar5;
		        }
		      }
		      func_ii_6628(*param3,iVar2 * 0x58 + 0x1b8,iVar3 * 0x58 + 0x1b8,param4_00,param5,iVar5,0);
		      iVar1 = iVar1 + 1;
		    } while (iVar1 < *(int *)(param2 + 0xc));
		  }
		  return;
		}
		*/

			return null;
		}

		// Token: 0x06003827 RID: 14375 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003827")]
		[Address(RVA = "0x87DE", Offset = "0x87DE", VA = "0x87DE", Slot = "6")]
		protected virtual void Draw(List<Point> points, ref Texture2D targetTexture)
		{
		/* --- GHIDRA: Draw ---
		void Gameplay_Combat_View_Spells_SpellFieldFigure__Draw(int param1,undefined4 param2)
		
		{
		  undefined8 local_10;
		  undefined8 local_8;
		  
		  local_10 = 0x42b0000042b00000;
		  local_8 = 0x42b0000042b00000;
		  UnityEngine_BoxCollider2D__get_size(*(undefined4 *)(param1 + 0x1c),&local_10,0);
		  return;
		}
		*/

		}

		// Token: 0x06003828 RID: 14376 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003828")]
		[Address(RVA = "0x87DF", Offset = "0x87DF", VA = "0x87DF")]
		private void Awake()
		{
		}

		// Token: 0x06003829 RID: 14377 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003829")]
		[Address(RVA = "0x87E0", Offset = "0x87E0", VA = "0x87E0", Slot = "4")]
		public void HandlePressRelease(IPlayerInput input)
		{
		/* --- GHIDRA: HandlePressRelease ---
		void Gameplay_Combat_View_Spells_SpellFieldFigure__HandlePressRelease(int param1,undefined4 param2)
		
		{
		  undefined4 param1_00;
		  
		  if (DAT_ram_00a566ed == '\0') {
		    Mono_Security_ASN1__get_Item
		              (&Method_System_Collections_Generic_Dictionary_uint__Sprite___ctor__);
		    Mono_Security_ASN1__get_Item(&System_Collections_Generic_Dictionary_uint__Sprite__TypeInfo);
		    DAT_ram_00a566ed = '\x01';
		  }
		  param1_00 = unnamed_function_1417(System_Collections_Generic_Dictionary_uint__Sprite__TypeInfo);
		  System_Collections_Generic_List_GAFAnimationAssetInternal_KeyFrame____ctor
		            (param1_00,Method_System_Collections_Generic_Dictionary_uint__Sprite___ctor__);
		  *(undefined4 *)(param1 + 0x24) = param1_00;
		  UnityEngine_RectTransform__GetParentSize(param1,0);
		  return;
		}
		*/

		}

		// Token: 0x0600382A RID: 14378 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600382A")]
		[Address(RVA = "0x87E1", Offset = "0x87E1", VA = "0x87E1")]
		public SpellFieldFigure()
		{
		}

		// Token: 0x04001F03 RID: 7939
		[Token(Token = "0x4001F03")]
		public const int MAX_TEMPLATE_COLUMS = 11;

		// Token: 0x04001F04 RID: 7940
		[Token(Token = "0x4001F04")]
		public const int MAX_TEMPLATE_ROWS = 11;

		// Token: 0x04001F05 RID: 7941
		[Token(Token = "0x4001F05")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private Texture2D _textureCenter;

		// Token: 0x04001F06 RID: 7942
		[Token(Token = "0x4001F06")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private Texture2D _texture;

		// Token: 0x04001F07 RID: 7943
		[Token(Token = "0x4001F07")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private SpriteRenderer _renderer;

		// Token: 0x04001F08 RID: 7944
		[Token(Token = "0x4001F08")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private BoxCollider2D _collider;

		// Token: 0x04001F09 RID: 7945
		[Token(Token = "0x4001F09")]
		[FieldOffset(Offset = "0x20")]
		private CombatSpellData _spell;

		// Token: 0x04001F0A RID: 7946
		[Token(Token = "0x4001F0A")]
		[FieldOffset(Offset = "0x24")]
		private Dictionary<uint, Sprite> _spritesCache;

		// Token: 0x04001F0B RID: 7947
		[Token(Token = "0x4001F0B")]
		[FieldOffset(Offset = "0x28")]
		private Color[] _texturePixels;

		// Token: 0x04001F0C RID: 7948
		[Token(Token = "0x4001F0C")]
		[FieldOffset(Offset = "0x2C")]
		private Color[] _centerTexturePixels;
	}

	// ================= UNMATCHED GHIDRA CODE =================

		/* --- GHIDRA: add_OnPointerUp ---
		void Gameplay_Combat_View_Spells_SpellFieldFigure__add_OnPointerUp
		               (int param1,undefined4 param2,undefined4 param3)
		
		{
		  bool bVar1;
		  int param1_00;
		  int *param1_01;
		  int iVar2;
		  
		  if (DAT_ram_00a566ea == '\0') {
		    Mono_Security_ASN1__get_Item(&System_Action_TypeInfo);
		    DAT_ram_00a566ea = '\x01';
		  }
		  param1_00 = *(int *)(param1 + 0x30);
		  while ((param1_01 = (int *)func_ii_7048(param1_00,param2,0), param1_01 == (int *)0x0 ||
		         (System_Action_TypeInfo == *param1_01))) {
		    iVar2 = func_ii_4329(param1 + 0x30,param1_01,param1_00);
		    bVar1 = iVar2 == param1_00;
		    param1_00 = iVar2;
		    if (bVar1) {
		      return;
		    }
		  }
		  System_Activator__CreateInstance(param1_01,System_Action_TypeInfo);
		  do {
		    halt_trap();
		  } while( true );
		}
		*/


		/* --- GHIDRA: remove_OnPointerUp ---
		int Gameplay_Combat_View_Spells_SpellFieldFigure__remove_OnPointerUp(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x28);
		  if (iVar1 == 0) {
		    iVar1 = UnityEngine_Texture2D__GetPixels(*(undefined4 *)(param1 + 0x14),0);
		    *(int *)(param1 + 0x28) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_TexturePixel ---
		int Gameplay_Combat_View_Spells_SpellFieldFigure__get_TexturePixel(int param1,undefined4 param2)
		
		{
		  int iVar1;
		  
		  iVar1 = *(int *)(param1 + 0x2c);
		  if (iVar1 == 0) {
		    iVar1 = UnityEngine_Texture2D__GetPixels(*(undefined4 *)(param1 + 0x10),0);
		    *(int *)(param1 + 0x2c) = iVar1;
		  }
		  return iVar1;
		}
		*/


		/* --- GHIDRA: get_Spell ---
		void Gameplay_Combat_View_Spells_SpellFieldFigure__get_Spell
		               (int *param1,int param2,undefined4 param3)
		
		{
		  int param1_00;
		  undefined4 param2_00;
		  
		  if (param2 != param1[8]) {
		    param1[8] = param2;
		    UnityEngine_Object__op_Implicit(param1[7],(uint)(param2 != 0),0);
		    param1_00 = param1[6];
		    if (param1[8] == 0) {
		      param2_00 = 0;
		    }
		    else {
		      param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                            (param1,param1[8],*(undefined4 *)(*param1 + 0xec));
		    }
		    Core_Extensions_SpriteAtlasExt__TryGetSprite(param1_00,param2_00,0);
		  }
		  return;
		}
		*/


		/* --- GHIDRA: set_Spell ---
		void Gameplay_Combat_View_Spells_SpellFieldFigure__set_Spell(int *param1,undefined4 param2)
		
		{
		  int param1_00;
		  undefined4 param2_00;
		  
		  UnityEngine_Object__op_Implicit(param1[7],(uint)(param1[8] != 0),0);
		  param1_00 = param1[6];
		  if (param1[8] == 0) {
		    param2_00 = 0;
		  }
		  else {
		    param2_00 = (**(code **)((ulonglong)*(uint *)(*param1 + 0xe8) * 4))
		                          (param1,param1[8],*(undefined4 *)(*param1 + 0xec));
		  }
		  Core_Extensions_SpriteAtlasExt__TryGetSprite(param1_00,param2_00,0);
		  return;
		}
		*/

}
