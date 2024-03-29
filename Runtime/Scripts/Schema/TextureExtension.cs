// Copyright 2020-2022 Andreas Atteneder
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//

namespace GLTFast.Schema
{

    /// <summary>
    /// Texture extensions
    /// </summary>
    [System.Serializable]
    public class TextureExtension
    {

        // ReSharper disable InconsistentNaming
        /// <inheritdoc cref="Extension.TextureBasisUniversal"/>
        public TextureBasisUniversal KHR_texture_basisu;

#if WEBP
        /// <inheritdoc cref="Extension.TextureWebP"/>
        public TextureWebP EXT_texture_webp;
#endif
        // ReSharper enable InconsistentNaming

        internal void GltfSerialize(JsonWriter writer)
        {
            throw new System.NotImplementedException($"GltfSerialize missing on {GetType()}");
        }
    }

    /// <summary>
    /// Basis Universal texture extension
    /// <seealso cref="Extension.TextureBasisUniversal"/>
    /// </summary>
    [System.Serializable]
    public class TextureBasisUniversal
    {

        /// <summary>
        /// Index of the image which defines a reference to the KTX v2 image
        /// with Basis Universal super-compression.
        /// </summary>
        public int source = -1;
    }

#if WEBP
    /// <summary>
    /// WebP texture extension
    /// <seealso cref="Extension.TextureWebP"/>
    /// </summary>
    [System.Serializable]
    public class TextureWebP
    {

        /// <summary>
        /// Index of the image which defines a reference to the WebP image.
        /// </summary>
        public int source = -1;
    }
#endif
}
