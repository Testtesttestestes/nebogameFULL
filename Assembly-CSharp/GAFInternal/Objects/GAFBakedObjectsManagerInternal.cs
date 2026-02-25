using System;
using System.Collections.Generic;
using GAFInternal.Core;
using GAFInternal.Data;
using Il2CppDummyDll;
using UnityEngine;

namespace GAFInternal.Objects
{
	// Token: 0x020013D5 RID: 5077
	[Token(Token = "0x20013D5")]
	[AddComponentMenu("")]
	[ExecuteInEditMode]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(GAFMeshManager))]
	[Serializable]
	public class GAFBakedObjectsManagerInternal<TypeOfObject> : GAFBaseObjectsManager where TypeOfObject : GAFBakedObjectInternal, new()
	{
		// Token: 0x170017F8 RID: 6136
		// (get) Token: 0x0600790B RID: 30987 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017F8")]
		public override GAFBaseClip clip
		{
			[Token(Token = "0x600790B")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017F9 RID: 6137
		// (get) Token: 0x0600790C RID: 30988 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017F9")]
		public override List<IGAFObject> objects
		{
			[Token(Token = "0x600790C")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017FA RID: 6138
		// (get) Token: 0x0600790D RID: 30989 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017FA")]
		public List<TypeOfObject> bakedObjects
		{
			[Token(Token = "0x600790D")]
			get
			{
				return null;
			}
		}

		// Token: 0x170017FB RID: 6139
		// (get) Token: 0x0600790E RID: 30990 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x170017FB")]
		public override Dictionary<uint, IGAFObject> objectsDict
		{
			[Token(Token = "0x600790E")]
			get
			{
				return null;
			}
		}

		// Token: 0x0600790F RID: 30991 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600790F")]
		public override void initialize()
		{
		}

		// Token: 0x06007910 RID: 30992 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007910")]
		public override void reload()
		{
		}

		// Token: 0x06007911 RID: 30993 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007911")]
		public override void cleanView()
		{
		}

		// Token: 0x06007912 RID: 30994 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007912")]
		public override void clear()
		{
		}

		// Token: 0x06007913 RID: 30995 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007913")]
		public override void deepClear()
		{
		}

		// Token: 0x06007914 RID: 30996 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007914")]
		public sealed override void updateToFrame(Dictionary<uint, GAFObjectStateData> _States, bool _Refresh)
		{
		}

		// Token: 0x06007915 RID: 30997 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007915")]
		public sealed override void updateToKeyFrame(List<GAFObjectStateData> _States)
		{
		}

		// Token: 0x06007916 RID: 30998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007916")]
		protected sealed override void createObjects()
		{
		}

		// Token: 0x06007917 RID: 30999 RVA: 0x00002052 File Offset: 0x00000252
		[Token(Token = "0x6007917")]
		private TypeOfObject createObject(string _Name, ObjectBehaviourType _Type, GAFObjectData _Data)
		{
			return null;
		}

		// Token: 0x06007918 RID: 31000 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6007918")]
		public GAFBakedObjectsManagerInternal()
		{
		}

		// Token: 0x04003F3C RID: 16188
		[Token(Token = "0x4003F3C")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		protected GAFBaseClip m_MovieClip;

		// Token: 0x04003F3D RID: 16189
		[Token(Token = "0x4003F3D")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		protected GAFMeshManager m_MeshManager;

		// Token: 0x04003F3E RID: 16190
		[Token(Token = "0x4003F3E")]
		[FieldOffset(Offset = "0x0")]
		[HideInInspector]
		[SerializeField]
		protected List<TypeOfObject> m_BakedObjects;

		// Token: 0x04003F3F RID: 16191
		[Token(Token = "0x4003F3F")]
		[FieldOffset(Offset = "0x0")]
		private Dictionary<uint, IGAFObject> m_ObjectsDict;
	}
}
